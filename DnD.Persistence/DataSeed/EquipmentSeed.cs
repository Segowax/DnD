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
                Guid = new Guid("2fbe30b3-5224-4d3e-880a-226f128ff24e"),
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
