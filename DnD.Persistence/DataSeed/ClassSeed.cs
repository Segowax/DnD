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
                Guid = new Guid("2d927dc9-9568-4554-9b42-2aae2a026409"),
                CreatedAt = new DateTime(2000, 10, 10).ToUniversalTime(),
                UpdatedAt = null,
                Name = "Warrior",
            });

            return builder;
        }
    }
}
