using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Voyager;
using HotChocolate;
using Persistence;
using Microsoft.Extensions.Logging;
using Application.GraphQL.Log.Events;
using HotChocolate.Execution;
using Application.GraphQL;
using Application.GraphQL.Queries;
using Application.GraphQL.ObjectTypes;
using Application.RestAPI;
using Application.GraphQL.Repositories;
using Domain.Concrete;
using Domain.Interfaces;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Authorization and Policies
            // services.AddAuthorization(opt =>{
            //     opt.AddPolicy("Admin", policy =>
            //     {
            //         policy.
            //     })
            // })
            // services.AddTransient<GameObjectRepository>(); //useful for extracting logic elswhere
            services.AddLogging(builder => builder.AddConsole());

            //Repositories
            services.AddScoped<IItemRepository, ItemRepository>(); //TODO: Study more on why I need this, and the benefits vs just using the Datacontext Service...
            services.AddScoped<IPawnRepository, PawnRepository>();
            // End //

            //HotChocolate GraphQL//////////////////////////////////////////////////////
            services.AddDataLoaderRegistry()
            .AddGraphQL(sp => SchemaBuilder.New()
                .AddServices(sp)
                // .AddAuthorizeDirectiveType() //TODO: Research use of Authorization vs Hiding fields
                .AddType<PotionType>()
                .AddType<PawnType>() //TODO: Do not implement base types only sub-types
                .AddQueryType(d => d.Name("Query"))
                .AddType<ItemQueries>()
                .AddType<PawnQueries>()
                .AddMutationType(d => d.Name("Mutation"))
                .AddType<PawnMutations>()
                .Use(_next => context =>
                {
                    // Example middleware
                    // send logs,
                    // track time for excution
                    // inject policies
                    // manipulate queries
                    return _next(context);
                })
                .ModifyOptions(o => o.RemoveUnreachableTypes = true)
                .Create());
            // End //

            //Add Databases in Dependency Injection Container
            services
            .AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
            })

            /*TODO: Look into additional DB... NOSQL for event store.
               // This wouldd likely be another Context of Type: EventStoreContext */

            // For Application/GraphQL/Log **Logging**
            .AddDiagnosticObserver<QueryObserver>() //TODO: Research how to better capture and command all events in my Services
            //End HotChocolate GraphQL//////////////////////////////////////////////////////

            .AddControllers();

            services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", builder =>
                 {
                     builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000");
                 });
            });
            services.AddMediatR(typeof(List.Handler).Assembly); //TODO: Research why I need MediatR vs having a static class that I delegate to..
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Ignoring this while developing
            // app.UseHttpsRedirection();

            app.UseCors("CorsPolicy");
            app
            .UseRouting()
            .UseWebSockets()
            .UseGraphQL()
            .UsePlayground()
            .UseVoyager();

            // app.UseAuthorization(); //TODO: Research safe techniques for integrating .Net Policy/Roles into Hot Chocolate

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
