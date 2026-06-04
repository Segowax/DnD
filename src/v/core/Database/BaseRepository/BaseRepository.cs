using Microsoft.EntityFrameworkCore;

namespace Database.BaseRepository
{
    public abstract class BaseRepository<TEntity>
        : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly IDbContextFactory _contextFactory;
        private readonly string _version;

        protected BaseRepository(IDbContextFactory contextFactory, string version)
        {
            _contextFactory = contextFactory;
            _version = version;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var context = _contextFactory.GetContext(_version);

            return await context.Set<TEntity>().ToListAsync();
        }
    }
}
