using AutoMapper;
using DnD.Application.Contracts.Persistence;
using MediatR;

namespace DnD.Application.Features.Race.Queries.GetRaceDetails
{
    public class GetRaceDetailsHandler : IRequestHandler<GetRaceDetailsQuery, GetRaceDetailsDto>
    {
        private readonly IMapper _mapper;
        private readonly IRaceRepository _raceRepository;

        public GetRaceDetailsHandler(IMapper mapper, IRaceRepository raceRepository)
        {
            _mapper = mapper;
            _raceRepository = raceRepository;
        }

        public async Task<GetRaceDetailsDto> Handle(GetRaceDetailsQuery request, CancellationToken cancellationToken)
        {
            var result = await _raceRepository.GetByGuidAsync(request.Guid, cancellationToken);

            return _mapper.Map<GetRaceDetailsDto>(result);
        }
    }
}
