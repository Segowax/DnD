using DnD.Application.Contracts.Persistence.Common;
using DnD.Domain;

namespace DnD.Application.Contracts.Persistence
{
    public interface IRaceRepository : IGenericRepository<Race>
    {
        Task<bool> IsRaceUnique(string raceName, CancellationToken cancellationToken = default);
    }
}
