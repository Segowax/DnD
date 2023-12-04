namespace DnD.Application.Contracts.Persistence.Common
{
    public interface IGenericRepository<T> where T : class
    {
        Task<bool> IsItemExistAsync(Guid guid, CancellationToken cancellationToken = default);
        Task<bool> IsItemUnique(string itemName, CancellationToken cancellationToken = default);
        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<T> GetByGuidAsync(Guid guid, CancellationToken cancellationToken = default);
        Task CreateAsync(T entity, CancellationToken cancellationToken = default);
        Task UpdateAsync(T entity, CancellationToken cancellationToken = default);
        Task DeleteAsync(T entity, CancellationToken cancellationToken = default);
    }
}