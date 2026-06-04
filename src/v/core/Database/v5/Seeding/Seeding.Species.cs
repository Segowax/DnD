using Database.v5.Domain;
using Microsoft.EntityFrameworkCore;

namespace v5.Data.Seeding
{
    internal static partial class Seeding
    {
        internal static DbContext SeedSpecies(this DbContext context)
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
                    new Species { Name = "Half-Elf" }
                );
                context.SaveChanges();
            }

            return context;
        }
    }
}
