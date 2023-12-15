using DnD.Application.Contracts.Persistence;
using DnD.Domain;
using DnD.Persistence.DatabaseContext;
using DnD.Persistence.Repositories.Common;

namespace DnD.Persistence.Repositories
{
    public class ClassRepository : GenericRepository<Class>, IClassRepository
    {
        public ClassRepository(DndDatabaseContext context) : base(context) { }
    }
}
