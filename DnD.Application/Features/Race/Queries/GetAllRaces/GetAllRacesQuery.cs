using MediatR;

namespace DnD.Application.Features.Race.Queries.GetAllRaces
{
    public record class GetAllRacesQuery : IRequest<IEnumerable<RaceDto>>;
}
