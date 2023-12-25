using DnD.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DnD.Persistence.DataSeed
{
    internal static class WeaponPropertySeed
    {
        internal static EntityTypeBuilder<WeaponProperty> WeaponPropertyDataSeed(this EntityTypeBuilder<WeaponProperty> builder)
        {
            builder.HasData(new WeaponProperty
            {
                Id = 1,
                Guid = Guid.NewGuid(),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Ammunition",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 2,
                Guid = Guid.NewGuid(),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Finese",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 3,
                Guid = Guid.NewGuid(),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Heavy",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 4,
                Guid = Guid.NewGuid(),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Light",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 5,
                Guid = Guid.NewGuid(),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Loading",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 6,
                Guid = Guid.NewGuid(),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Range",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 7,
                Guid = Guid.NewGuid(),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Reach",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 8,
                Guid = Guid.NewGuid(),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Special",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 9,
                Guid = Guid.NewGuid(),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Thrown",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 10,
                Guid = Guid.NewGuid(),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "TwoHanded",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 11,
                Guid = Guid.NewGuid(),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Versatile",
                Description = "ToDo"
            });

            return builder;
        }
    }
}
