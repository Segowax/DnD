﻿using DnD.Domain;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RaceConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in base.ChangeTracker.Entries<BaseEntity>()
                .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
            {
                entry.Entity.UpdatedAt = DateTime.UtcNow;
                if (entry.State == EntityState.Added)
                    entry.Entity.CreatedAt = DateTime.UtcNow;
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}