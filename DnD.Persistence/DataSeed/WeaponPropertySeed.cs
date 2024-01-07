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
                Guid = new Guid("e401be37-3cb8-4339-9430-3a34a6fef085"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Ammunition",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 2,
                Guid = new Guid("b76727ec-fcd0-4eb2-828c-899816c189d8"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Finese",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 3,
                Guid = new Guid("b7ab8d98-23bb-41a5-94b5-8a9c76f68984"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Heavy",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 4,
                Guid = new Guid("2df462bf-bd85-48b0-aa92-f85effa01699"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Light",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 5,
                Guid = new Guid("67b269a2-3e40-45f7-b36f-ca08ce15f6cb"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Loading",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 6,
                Guid = new Guid("daa57348-ca21-4341-85c4-056053229f55"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Range",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 7,
                Guid = new Guid("d3b01956-8a13-408d-8bc4-0107679440ab"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Reach",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 8,
                Guid = new Guid("953e1537-beb8-4050-ab3a-5af85a7cf926"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Special",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 9,
                Guid = new Guid("a4b19609-98b1-4971-81ca-ec68ecfaf838"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Thrown",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 10,
                Guid = new Guid("c63d671d-e816-4ba4-ab3a-96872c7f7fd9"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "TwoHanded",
                Description = "ToDo"
            });

            builder.HasData(new WeaponProperty
            {
                Id = 11,
                Guid = new Guid("cfac124a-0ee0-432b-8aad-e43ddd40e1e0"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Versatile",
                Description = "ToDo"
            });

            return builder;
        }
    }
}
