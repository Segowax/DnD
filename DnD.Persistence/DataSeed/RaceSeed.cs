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
                Guid = new Guid("7f699f15-a972-404c-b2cc-f54315a87442"),
                Name = "Human",
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
            });

            return builder;
        }
    }
}
