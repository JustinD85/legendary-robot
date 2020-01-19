using Domain;
using Domain.Concrete;
using Domain.Concrete.KanjiAliveAPI;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        /*
            comment/uncomment things you do/don't want to query against.
            Then migrate the Database.
        */

        public DbSet<Value> Values { get; set; }
        // All
        // public DbSet<AActor> Actors { get; set; }

        // Generic
        // public DbSet<Building> Buildings { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Pawn> Pawns { get; set; }
        public DbSet<KanjiAliveAPI> Kanji { get; set; }

        //Specific
        // public DbSet<Potion> Potions { get; set; }

        //Sub-Type
    }
}
