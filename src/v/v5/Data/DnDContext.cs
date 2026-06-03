using Common.Domain;
using Microsoft.EntityFrameworkCore;
using v5.Data.Domain;
using v5.Data.Seeding;

namespace v5.Data
{
    public class DnDContext : DbContext
    {
        public DbSet<Languages> Languages { get; set; }
        public DbSet<Species> AvailableSpecies { get; set; }

        public DnDContext() { }
        public DnDContext(DbContextOptions<DnDContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=v5.db")
                .SeedLanguages()
                .SeedSpecies();
        }
    }

}
