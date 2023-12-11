using DnD.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DnD.Persistence.Configurations
{
    public class AbilityScoresConfiguration : IEntityTypeConfiguration<AbilityScores>
    {
        public void Configure(EntityTypeBuilder<AbilityScores> builder)
        {
            // Configurations
        }
    }
}
