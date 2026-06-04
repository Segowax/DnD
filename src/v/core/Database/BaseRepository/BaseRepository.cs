using Domain;
using Microsoft.EntityFrameworkCore;

namespace Database.BaseRepository
{
    public abstract class BaseRepository<TContext, TEntity>
        : IBaseRepository<TContext, TEntity>
        where TContext : DbContext
        where TEntity : Base
    {
        private readonly IDbContextFactory<TContext> _contextFactory;

        protected BaseRepository(IDbContextFactory<TContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var context = _contextFactory.GetContext();

            return await context.Set<TEntity>().ToListAsync();
        }
    }
}
