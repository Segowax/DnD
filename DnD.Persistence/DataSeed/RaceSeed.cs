using DnD.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DnD.Persistence.DataSeed
{
    internal static class RaceSeed
    {
        internal static EntityTypeBuilder<Race> RaceDataSeed(this EntityTypeBuilder<Race> builder)
        {
            // ToDo Rest of data
            builder.HasData(new Race()
            {
                Id = 1,
                Guid = new Guid("0c28c0e5-e89c-4070-bcd6-26f361af58f5"),
                Name = "Human",
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
            });

            return builder;
        }
    }
}
