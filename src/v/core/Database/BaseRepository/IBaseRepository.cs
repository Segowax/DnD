using Domain;
using Microsoft.EntityFrameworkCore;

namespace Database.BaseRepository
{
    public interface IBaseRepository<Ctx, TEntity>
        where Ctx : DbContext
        where TEntity : Base
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
