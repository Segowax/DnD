using Domain;
using Microsoft.EntityFrameworkCore;

namespace v5.Data.Configurations
{
    internal static partial class Configuration
    {
        internal static ModelBuilder ConfigureLanguages(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Languages>()
                .HasIndex(l => l.Name)
                .IsUnique();

            modelBuilder.Entity<Languages>()
                .Property(p => p.Guid)
                .ValueGeneratedOnAdd();

            return modelBuilder;
        }
    }
}
