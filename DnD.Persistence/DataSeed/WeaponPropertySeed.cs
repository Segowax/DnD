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
                Guid = new Guid("13e4e1c8-9548-44ec-bd09-4c1c2ca29257"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Ammunition",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 2,
                Guid = new Guid("934fc7fe-1fcc-4600-a7b0-46dd1624b953"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Finese",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 3,
                Guid = new Guid("a379b070-07f0-4ea3-b06d-4effb3eb5caa"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Heavy",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 4,
                Guid = new Guid("e47f5ba5-4830-435c-9041-12f8af485396"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Light",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 5,
                Guid = new Guid("c79679dc-59ab-4c88-afeb-a9f65fdaabcb"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Loading",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 6,
                Guid = new Guid("90e5449b-9d24-4618-a40c-26731204a3dc"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Range",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 7,
                Guid = new Guid("9d941ecd-e212-4852-8231-f040f15f11f5"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Reach",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 8,
                Guid = new Guid("43790d45-7251-45df-ae26-9107345b495d"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Special",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 9,
                Guid = new Guid("395fd1d3-4a34-44da-b50c-74bc85149e47"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Thrown",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 10,
                Guid = new Guid("5088da03-2e65-4c63-8a13-27c31d2b7593"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "TwoHanded",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 11,
                Guid = new Guid("523b4c22-aa24-4aef-962f-7831ec531360"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Versatile",
                Description = "ToDo"
            });

            return builder;
        }
    }
}
