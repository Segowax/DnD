using AutoMapper;
using DnD.Application.Contracts.Logging;
using DnD.Application.Contracts.Persistence;
using DnD.Application.Properties;
using DnD.Common.Enums;
using MediatR;

namespace DnD.Application.Features.Race.Queries.GetAllRaces
{
    public class GetAllRacesHandler : IRequestHandler<GetAllRacesQuery, IEnumerable<GetAllRacesDto>>
    {
        private readonly IMapper _mapper;
        private readonly IAppLogger<GetAllRacesHandler> _logger;
        private readonly IRaceRepository _raceRepository;

        public GetAllRacesHandler(IMapper mapper,
            IAppLogger<GetAllRacesHandler> logger,
            IRaceRepository raceRepository)
        {
            _mapper = mapper;
            _logger = logger;
            _raceRepository = raceRepository;
        }

        public async Task<IEnumerable<GetAllRacesDto>> Handle(GetAllRacesQuery request, CancellationToken cancellationToken)
        {
            _logger.LogDebug(Resources.Logger_Debug_StartHandler, nameof(Crud.read), nameof(Domain.Race), nameof(GetAllRacesQuery));
            var result = await _raceRepository.GetAllAsync(cancellationToken);
            _logger.LogDebug(Resources.Logger_Debug_EndHandler, nameof(Crud.read), nameof(Domain.Race), nameof(GetAllRacesQuery));

            return _mapper.Map<IEnumerable<GetAllRacesDto>>(result);
        }
    }
}
