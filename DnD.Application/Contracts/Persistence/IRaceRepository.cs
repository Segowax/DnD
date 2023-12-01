using DnD.Domain;

namespace DnD.Application.Contracts.Persistence
{
    public interface IRaceRepository : IGenericRepository<Race>
    {
        Task<bool> IsRaceUnique(string race, CancellationToken cancellationToken = default);
    }
}
