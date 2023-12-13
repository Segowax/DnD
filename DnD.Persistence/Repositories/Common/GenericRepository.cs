using DnD.Application.Contracts.Persistence.Common;
using DnD.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace DnD.Persistence.Repositories.Common
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DndDatabaseContext _context;

        public GenericRepository(DndDatabaseContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity, CancellationToken cancellationToken = default)
        {
            await _context.AddAsync(entity, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<IReadOnlyList<T>> GetAllAsync(CancellationToken cancellationToken = default) =>
            await _context.Set<T>().ToListAsync();

        public async Task<T?> GetByGuidAsync(Guid guid, CancellationToken cancellationToken = default) =>
            await _context.Set<T>().FindAsync(guid, cancellationToken);

        public async Task<bool> IsItemExistAsync(Guid guid, CancellationToken cancellationToken = default)
        {
            var item = await _context.Set<T>().FindAsync(guid, cancellationToken);
            if (item is null) return false;

            return true;
        }

        public async Task UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
