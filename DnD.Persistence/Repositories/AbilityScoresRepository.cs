using DnD.Application.Contracts.Persistence;
using DnD.Domain;
using DnD.Persistence.DatabaseContext;
using DnD.Persistence.Repositories.Common;

namespace DnD.Persistence.Repositories
{
    public class AbilityScoresRepository : GenericRepository<AbilityScores>, IAbilityScoresRepository
    {
        public AbilityScoresRepository(DndDatabaseContext context) : base(context) { }
    }
}
