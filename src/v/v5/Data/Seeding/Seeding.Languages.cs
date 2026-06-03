using Common.Domain;
using Microsoft.EntityFrameworkCore;

namespace v5.Data.Seeding
{
    public static partial class Seeding
    {
        public static DbContext SeedLanguages(this DbContext ctx)
        {
            if (!ctx.Set<Languages>().Any())
            {
                ctx.Set<Languages>().AddRange(
                        new Languages { Name = "Abyssal" },
                        new Languages { Name = "Celestial" },
                        new Languages { Name = "Common Sign Language" },
                        new Languages { Name = "Deep Speech" },
                        new Languages { Name = "Draconic" },
                        new Languages { Name = "Druidic" },
                        new Languages { Name = "Dwarvish" },
                        new Languages { Name = "Elvish" },
                        new Languages { Name = "Giant" },
                        new Languages { Name = "Gnomish" },
                        new Languages { Name = "Goblin" },
                        new Languages { Name = "Halfling" },
                        new Languages { Name = "Infernal" },
                        new Languages { Name = "Orc" },
                        new Languages { Name = "Primordial" },
                        new Languages { Name = "Sylvan" },
                        new Languages { Name = "Thieves' Cant" },
                        new Languages { Name = "Undercommon" }
                    );
                ctx.SaveChanges();
            }

            return ctx;
        }
    }
}
