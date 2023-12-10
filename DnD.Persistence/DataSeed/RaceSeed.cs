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
                Guid = Guid.NewGuid(),
                Name = "Human",
                CreatedAt = new DateTime(2000, 10, 10),
                UpdatedAt = null,
            });

            return builder;
        }
    }
}
