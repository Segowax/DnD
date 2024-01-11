using MediatR;

namespace DnD.Application.Features.Race.Queries.GetRaceDetails
{
    public record GetRaceDetailsQuery(Guid Guid) : IRequest<GetRaceDetailsDto>;
}
