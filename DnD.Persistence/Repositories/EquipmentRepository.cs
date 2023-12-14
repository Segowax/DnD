using DnD.Application.Contracts.Persistence;
using DnD.Domain;
using DnD.Persistence.DatabaseContext;
using DnD.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace DnD.Persistence.Repositories
{
    public class EquipmentRepository : GenericRepository<Equipment>, IEquipmentRepository
    {
        public EquipmentRepository(DndDatabaseContext context) : base(context) { }

        public async Task<bool> IsEquipmentNameUnique(string name, CancellationToken cancellationToken = default) =>
            !(await _context.Equipments.AnyAsync(x => x.Name.Equals(name), cancellationToken));

    }
}
