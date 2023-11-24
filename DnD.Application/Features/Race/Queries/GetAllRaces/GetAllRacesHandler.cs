using AutoMapper;
using DnD.Application.Contracts.Persistence;
using MediatR;

namespace DnD.Application.Features.Race.Queries.GetAllRaces
{
    public class GetAllRacesHandler : IRequestHandler<GetAllRacesQuery, IEnumerable<GetAllRacesDto>>
    {
        private readonly IMapper _mapper;
        private readonly IRaceRepository _raceRepository;

        public GetAllRacesHandler(IMapper mapper, IRaceRepository raceRepository)
        {
            _mapper = mapper;
            _raceRepository = raceRepository;
        }

        public async Task<IEnumerable<GetAllRacesDto>> Handle(GetAllRacesQuery request, CancellationToken cancellationToken)
        {
            var result = await _raceRepository.GetAllAsync(cancellationToken);

            return _mapper.Map<IEnumerable<GetAllRacesDto>>(result);
        }
    }
}
