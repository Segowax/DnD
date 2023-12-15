using DnD.Application.Contracts.Persistence;
using DnD.Domain;
using DnD.Persistence.DatabaseContext;
using DnD.Persistence.Repositories.Common;

namespace DnD.Persistence.Repositories
{
    public class DescriptionRepository : GenericRepository<Description>, IDescriptionRepository
    {
        public DescriptionRepository(DndDatabaseContext context) : base(context) { }
    }
}
