using Application.GameObjects;
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
using Application.Types;
using Domain;

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
            //HotChocolate GraphQL
            services.AddDataLoaderRegistry();
            // Add GraphQL Services
            services.AddGraphQL(sp => SchemaBuilder.New()
                .AddServices(sp)
                // enable for authorization support
                .AddAuthorizeDirectiveType()
                .AddQueryType<Query>()
                .AddType<Value>()
                .AddType<GameObject>()
                .ModifyOptions(o => o.RemoveUnreachableTypes = true)
                .Create());
            //HotChocolate GraphQL
            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddControllers();

            services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", builder =>
                 {
                     builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000");
                 });
            });
            services.AddMediatR(typeof(List.Handler).Assembly);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Ignoring this while developing, for now
            // app.UseHttpsRedirection();

            app.UseCors("CorsPolicy");
            app
            .UseRouting()
            .UseWebSockets()
            .UseGraphQL()
            .UsePlayground()
            .UseVoyager();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
