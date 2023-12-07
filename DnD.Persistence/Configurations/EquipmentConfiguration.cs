using DnD.Common.Enums;
using DnD.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DnD.Persistence.Configurations
{
    public class EquipmentConfiguration : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.HasData(new Equipment()
            {
                Id = 1,
                Guid = Guid.NewGuid(),
                Name = "BattleAxe",
                Cost = 1000,
                Damage = "1d8",
                Properties = { WeaponProperties.Versatile },
                Weight = 4,
                Description = "-",
                CreatedAt = new DateTime(2000, 10, 10),
                UpdatedAt = null
            });
        }
    }
}
