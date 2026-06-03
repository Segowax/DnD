using Microsoft.EntityFrameworkCore;
using v5.Data.Domain;

namespace v5.Data.Configurations
{
    internal static partial class Configuration
    {
        internal static ModelBuilder ConfigureSpecies(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Species>()
                .HasIndex(s => s.Name)
                .IsUnique();
            modelBuilder.Entity<Species>()
                .Property(p => p.Guid)
                .ValueGeneratedOnAdd();

            return modelBuilder;
        }
    }
}
