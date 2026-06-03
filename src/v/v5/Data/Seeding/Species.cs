using Microsoft.EntityFrameworkCore;
using v5.Data.Domain;

namespace v5.Data.Seeding
{
    public static partial class Seeding
    {
        public static DbContextOptionsBuilder SeedSpecies(this DbContextOptionsBuilder builder)
        {
            builder.UseSeeding((context, _) =>
            {
                if (!context.Set<Species>().Any())
                {
                    context.Set<Species>().AddRange(
                        new Species { Name = "Dragonborn" },
                        new Species { Name = "Dwarf" },
                        new Species { Name = "Elf" },
                        new Species { Name = "Gnome" },
                        new Species { Name = "Halfling" },
                        new Species { Name = "Human" },
                        new Species { Name = "Half-Orc" },
                        new Species { Name = "Half-Orc" }
                    );
                    context.SaveChanges();
                }
            });

            return builder;
        }
    }
}
