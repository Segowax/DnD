using AutoMapper;
using DnD.Application.Contracts.Logging;
using DnD.Application.Contracts.Persistence;
using DnD.Application.Properties;
using DnD.Common.Enums;
using MediatR;

namespace DnD.Application.Features.Race.Queries.GetRaceDetails
{
    public class GetRaceDetailsHandler : IRequestHandler<GetRaceDetailsQuery, GetRaceDetailsDto>
    {
        private readonly IMapper _mapper;
        private readonly IAppLogger<GetRaceDetailsHandler> _logger;
        private readonly IRaceRepository _raceRepository;

        public GetRaceDetailsHandler(IMapper mapper,
            IAppLogger<GetRaceDetailsHandler> logger,
            IRaceRepository raceRepository)
        {
            _mapper = mapper;
            _logger = logger;
            _raceRepository = raceRepository;
        }

        public async Task<GetRaceDetailsDto> Handle(GetRaceDetailsQuery request, CancellationToken cancellationToken)
        {
            _logger.LogDebug(Resources.Logger_Debug_StartHandler, nameof(Crud.read), nameof(Domain.Race), request.Guid);
            var result = await _raceRepository.GetByGuidAsync(request.Guid, cancellationToken);
            _logger.LogDebug(Resources.Logger_Debug_EndHandler, nameof(Crud.read), nameof(Domain.Race), request.Guid);

            return _mapper.Map<GetRaceDetailsDto>(result);
        }
    }
}
