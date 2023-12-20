using AutoMapper;
using DnD.Application.Contracts.Logging;
using DnD.Application.Contracts.Persistence;
using DnD.Application.Exceptions;
using DnD.Application.Properties;
using DnD.Common.Enums;
using MediatR;

namespace DnD.Application.Features.Equipment.Commands.DeleteEquipment
{
    public class DeleteEquipmentHandler : IRequestHandler<DeleteEquipmentCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IAppLogger<DeleteEquipmentHandler> _logger;
        private readonly IEquipmentRepository _equipmentRepository;

        public DeleteEquipmentHandler(IMapper mapper,
            IAppLogger<DeleteEquipmentHandler> logger,
            IEquipmentRepository raceRepository)
        {
            _mapper = mapper;
            _logger = logger;
            _equipmentRepository = raceRepository;
        }

        public async Task<Unit> Handle(DeleteEquipmentCommand request, CancellationToken cancellationToken)
        {
            _logger.LogDebug(Resources.Logger_Debug_StartHandler, nameof(Crud.delete), nameof(Domain.Equipment), request.Guid);
            var validator = new DeleteEquipmentValidator();
            var validatorResult = await validator.ValidateAsync(request, cancellationToken);
            if (!validatorResult.IsValid)
            {
                _logger.LogWarning(Resources.Logger_Warning_Validator, nameof(Crud.delete), nameof(Domain.Equipment), request.Guid);
                throw new BadRequestException(nameof(DeleteEquipmentHandler), validatorResult);
            }

            var dataToDelete = _mapper.Map<Domain.Equipment>(request);
            if (dataToDelete == null)
            {
                _logger.LogWarning(Resources.Logger_Warning_Null, nameof(Crud.delete), nameof(Domain.Equipment), request.Guid);
                throw new NotFoundException(nameof(Domain.Equipment), request.Guid);
            }
            await _equipmentRepository.DeleteAsync(dataToDelete, cancellationToken);
            _logger.LogDebug(Resources.Logger_Debug_EndHandler, nameof(Crud.delete), nameof(Domain.Equipment), request.Guid);

            return Unit.Value;
        }
    }
}
