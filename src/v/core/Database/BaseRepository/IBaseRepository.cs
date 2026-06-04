namespace Database.BaseRepository
{
    public interface IBaseRepository<TEntity> 
        where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
