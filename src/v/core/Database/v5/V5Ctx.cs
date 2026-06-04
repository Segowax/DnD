using Domain;
using Domain.v5;
using Microsoft.EntityFrameworkCore;
using v5.Data.Configurations;
using v5.Data.Seeding;

namespace Database.v5
{
    public class V5Ctx : DbContext
    {
        public DbSet<Languages> Languages { get; set; }
        public DbSet<Species> AvailableSpecies { get; set; }

        public V5Ctx() { }
        public V5Ctx(DbContextOptions<V5Ctx> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=v5.db")
                .UseSeeding((context, _) =>
                {
                    context
                        .SeedLanguages()
                        .SeedSpecies();
                });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .ConfigureLanguages()
                .ConfigureSpecies();
        }
    }

}
