using DnD.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DnD.Persistence.Configurations
{
    public class RaceConfiguration : IEntityTypeConfiguration<Race>
    {
        public void Configure(EntityTypeBuilder<Race> builder)
        {
            builder.HasData(new Race()
            {
                Id = 1,
                Guid = Guid.NewGuid(),
                Name = "Human",
                CreatedAt = new DateTime(2000, 10, 10),
                UpdatedAt = null,
            });
        }
    }
}
