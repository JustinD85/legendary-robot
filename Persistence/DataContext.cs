using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
            .HasData(
                new Value { Id = 1, Name = "value 1" },
                new Value { Id = 2, Name = "value 2" },
                new Value { Id = 3, Name = "value 3" },
                new Value { Id = 4, Name = "value 4" },
                new Value { Id = 5, Name = "value 5" },
                new Value { Id = 6, Name = "value 6" },
                new Value { Id = 7, Name = "value 7" }
            );
        }
    }
}
