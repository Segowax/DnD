using DnD.Domain;
using DnD.Persistence.DataSeed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DnD.Persistence.Configurations
{
    public class WeaponPropertyConfiguration : IEntityTypeConfiguration<WeaponProperty>
    {
        public void Configure(EntityTypeBuilder<WeaponProperty> builder)
        {
            // Configurations

            // Data Seed
            builder.WeaponPropertyDataSeed();
        }
    }
}
