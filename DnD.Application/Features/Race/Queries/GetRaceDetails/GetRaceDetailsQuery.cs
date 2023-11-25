using MediatR;

namespace DnD.Application.Features.Race.Queries.GetRaceDetails
{
    public record class GetRaceDetailsQuery(Guid Guid) : IRequest<GetRaceDetailsDto>;
}
