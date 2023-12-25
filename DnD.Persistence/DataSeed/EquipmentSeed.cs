using DnD.Common.Enums;
using DnD.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DnD.Persistence.DataSeed
{
    internal static class EquipmentSeed
    {
        internal static EntityTypeBuilder<Equipment> EquipmentDataSeed(this EntityTypeBuilder<Equipment> builder)
        {
            // ToDo Rest of data
            builder.HasData(new Equipment()
            {
                Id = 1,
                Guid = Guid.NewGuid(),
                Name = "BattleAxe",
                Cost = 1000,
                Damage = "1d8",
                // Properties = { WeaponProperties.Versatile },
                Weight = 4,
                Description = "-",
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null
            });

            return builder;
        }
    }
}
