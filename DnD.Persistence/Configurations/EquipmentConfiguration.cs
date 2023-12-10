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

            // Data Seed
            builder.EquipmentDataSeed();
        }
    }
}
