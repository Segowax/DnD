using DnD.Domain;
using DnD.Domain.Common;
using DnD.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace DnD.Persistence.DatabaseContext
{
    public class DndDatabaseContext : DbContext
    {
        public DndDatabaseContext(DbContextOptions<DndDatabaseContext> options) : base(options) { }

        public DbSet<AbilityScores> Abilities { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<WeaponProperty> WeaponProperties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Data to seed
            modelBuilder.ApplyConfiguration(new EquipmentConfiguration());
            modelBuilder.ApplyConfiguration(new RaceConfiguration());
            modelBuilder.ApplyConfiguration(new WeaponPropertyConfiguration());
            // Data without seed
            modelBuilder.ApplyConfiguration(new AbilityScoresConfiguration());
            modelBuilder.ApplyConfiguration(new CharacterConfiguration());
            modelBuilder.ApplyConfiguration(new ClassConfiguration());
            modelBuilder.ApplyConfiguration(new DescriptionConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in base.ChangeTracker.Entries<BaseEntity>()
                .Where(q => q.State is EntityState.Added or EntityState.Modified))
            {
                entry.Entity.UpdatedAt = DateTime.UtcNow;
                if (entry.State == EntityState.Added)
                    entry.Entity.CreatedAt = DateTime.UtcNow;
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
