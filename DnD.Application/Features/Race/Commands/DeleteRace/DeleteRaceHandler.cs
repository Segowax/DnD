using AutoMapper;
using DnD.Application.Contracts.Logging;
using DnD.Application.Contracts.Persistence;
using DnD.Application.Exceptions;
using DnD.Application.Properties;
using DnD.Common.Enums;
using MediatR;

namespace DnD.Application.Features.Race.Commands.DeleteRace
{
    public class DeleteRaceHandler : IRequestHandler<DeleteRaceCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IAppLogger<DeleteRaceHandler> _logger;
        private readonly IRaceRepository _raceRepository;

        public DeleteRaceHandler(IMapper mapper,
            IAppLogger<DeleteRaceHandler> logger,
            IRaceRepository raceRepository)
        {
            _mapper = mapper;
            _logger = logger;
            _raceRepository = raceRepository;
        }

        public async Task<Unit> Handle(DeleteRaceCommand request, CancellationToken cancellationToken)
        {
            _logger.LogDebug(Resources.Logger_Debug_StartHandler, nameof(Crud.delete), nameof(Domain.Race), request.Guid);
            var validator = new DeleteRaceValidator();
            var validatorResult = await validator.ValidateAsync(request, cancellationToken);
            if (!validatorResult.IsValid)
            {
                _logger.LogWarning(Resources.Logger_Warning_Validator, nameof(Crud.delete), nameof(Domain.Race), request.Guid);
                throw new BadRequestException(nameof(DeleteRaceHandler), validatorResult);
            }

            var dataToDelete = _mapper.Map<Domain.Race>(request);
            if (dataToDelete == null)
            {
                _logger.LogWarning(Resources.Logger_Warning_Null, nameof(Crud.delete), nameof(Domain.Race), request.Guid);
                throw new NotFoundException(nameof(Domain.Race), request.Guid);
            }
            await _raceRepository.DeleteAsync(dataToDelete, cancellationToken);
            _logger.LogDebug(Resources.Logger_Debug_EndHandler, nameof(Crud.delete), nameof(Domain.Equipment), request.Guid);

            return Unit.Value;
        }
    }
}
