using DnD.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DnD.Persistence.DataSeed
{
    internal static class ClassSeed
    {
        internal static EntityTypeBuilder<Class> ClassDataSeed(this EntityTypeBuilder<Class> builder)
        {
            builder.HasData(new Class()
            {
                Id = 1,
                Guid = Guid.NewGuid(),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Warrior",
            });

            return builder;
        }
    }
}
