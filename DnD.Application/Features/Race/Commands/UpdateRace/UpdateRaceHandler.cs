using AutoMapper;
using DnD.Application.Contracts.Logging;
using DnD.Application.Contracts.Persistence;
using DnD.Application.Exceptions;
using DnD.Application.Properties;
using DnD.Common.Enums;
using MediatR;

namespace DnD.Application.Features.Race.Commands.UpdateRace
{
    public class UpdateRaceHandler : IRequestHandler<UpdateRaceCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IAppLogger<UpdateRaceHandler> _logger;
        private readonly IRaceRepository _raceRepsitory;

        public UpdateRaceHandler(IMapper mapper,
            IAppLogger<UpdateRaceHandler> logger,
            IRaceRepository raceRepository)
        {
            _mapper = mapper;
            _logger = logger;
            _raceRepsitory = raceRepository;
        }

        public async Task<Unit> Handle(UpdateRaceCommand request, CancellationToken cancellationToken)
        {
            _logger.LogDebug(Resources.Logger_Debug_StartHandler, nameof(Crud.update), nameof(Domain.Race), request.Guid);
            var validator = new UpdateRaceValidator(_raceRepsitory);
            var validatorResult = await validator.ValidateAsync(request);
            if (!validatorResult.IsValid)
            {
                _logger.LogWarning(Resources.Logger_Warning_Validator, nameof(Crud.update), nameof(Domain.Race), request.Guid);
                throw new BadRequestException(nameof(UpdateRaceHandler), validatorResult);
            }

            var dataToUpdate = _mapper.Map<Domain.Race>(request);
            await _raceRepsitory.UpdateAsync(dataToUpdate, cancellationToken);
            _logger.LogDebug(Resources.Logger_Debug_EndHandler, nameof(Crud.update), nameof(Domain.Equipment), request.Guid);

            return Unit.Value;
        }
    }
}
