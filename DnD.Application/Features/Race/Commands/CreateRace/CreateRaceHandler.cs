using AutoMapper;
using DnD.Application.Contracts.Logging;
using DnD.Application.Contracts.Persistence;
using DnD.Application.Exceptions;
using DnD.Application.Properties;
using DnD.Common.Enums;
using MediatR;

namespace DnD.Application.Features.Race.Commands.CreateRace
{
    public class CreateRaceHandler : IRequestHandler<CreateRaceCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IAppLogger<CreateRaceHandler> _logger;
        private readonly IRaceRepository _raceRepository;

        public CreateRaceHandler(IMapper mapper,
            IAppLogger<CreateRaceHandler> logger,
            IRaceRepository raceRepository)
        {
            _mapper = mapper;
            _logger = logger;
            _raceRepository = raceRepository;
        }
        public async Task<Unit> Handle(CreateRaceCommand request, CancellationToken cancellationToken)
        {
            _logger.LogDebug(Resources.Logger_Debug_StartHandler, nameof(Crud.create), nameof(Domain.Race), request.Name);
            var validator = new CreateRaceValidator(_raceRepository);
            var validatorResult = await validator.ValidateAsync(request, cancellationToken);
            if (!validatorResult.IsValid)
            {
                _logger.LogWarning(Resources.Logger_Warning_Validator, nameof(Crud.create), nameof(Domain.Race), request.Name);
                throw new BadRequestException(nameof(CreateRaceHandler), validatorResult);
            }

            var dataToCreate = _mapper.Map<Domain.Race>(request);
            await _raceRepository.CreateAsync(dataToCreate, cancellationToken);
            _logger.LogDebug(Resources.Logger_Debug_EndHandler, nameof(Crud.create), nameof(Domain.Race), request.Name);

            return Unit.Value;
        }
    }
}
