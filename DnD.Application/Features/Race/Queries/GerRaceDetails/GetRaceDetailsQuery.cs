using DnD.Application.Features.Race.Queries.GetAllRaces;
using MediatR;

namespace DnD.Application.Features.Race.Queries.GerRaceDetails
{
    public record class GetRaceDetailsQuery(Guid Guid) : IRequest<GetRaceDetailsDto>;
}
