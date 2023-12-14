using DnD.Domain.Common;

namespace DnD.Application.Contracts.Persistence.Common
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<bool> IsItemExistAsync(Guid guid, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<T>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<T?> GetByGuidAsync(Guid guid, CancellationToken cancellationToken = default);
        Task CreateAsync(T entity, CancellationToken cancellationToken = default);
        Task UpdateAsync(T entity, CancellationToken cancellationToken = default);
        Task DeleteAsync(T entity, CancellationToken cancellationToken = default);
    }
}