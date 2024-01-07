using DnD.Domain;
using DnD.Persistence.DataSeed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DnD.Persistence.Configurations
{
    public class EquipmentConfiguration : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            // Configurations
            builder.HasIndex(x => x.Guid).IsUnique();
            builder.Property(x => x.Guid).ValueGeneratedOnAdd();
            // Data Seed
            builder.EquipmentDataSeed();
        }
    }
}
