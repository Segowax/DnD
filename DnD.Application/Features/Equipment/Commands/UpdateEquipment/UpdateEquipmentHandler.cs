using AutoMapper;
using DnD.Application.Contracts.Logging;
using DnD.Application.Contracts.Persistence;
using DnD.Application.Exceptions;
using DnD.Application.Properties;
using DnD.Common.Enums;
using MediatR;

namespace DnD.Application.Features.Equipment.Commands.UpdateEquipment
{
    public class UpdateEquipmentHandler : IRequestHandler<UpdateEquipmentCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IAppLogger<UpdateEquipmentHandler> _logger;
        private readonly IEquipmentRepository _equipmentRepository;

        public UpdateEquipmentHandler(IMapper mapper,
            IAppLogger<UpdateEquipmentHandler> logger,
            IEquipmentRepository equipmentRepository)
        {
            _mapper = mapper;
            _logger = logger;
            _equipmentRepository = equipmentRepository;
        }

        public async Task<Unit> Handle(UpdateEquipmentCommand request, CancellationToken cancellationToken)
        {
            _logger.LogDebug(Resources.Logger_Debug_StartHandler, nameof(Crud.create), nameof(Domain.Equipment), request.Guid);
            var validator = new UpdateEquipmentValidator(_equipmentRepository);
            var validatorResult = await validator.ValidateAsync(request, cancellationToken);
            if (!validatorResult.IsValid)
            {
                _logger.LogWarning(Resources.Logger_Warning_Validator, nameof(Crud.create), nameof(Domain.Equipment), request.Guid);
                throw new BadRequestException(nameof(UpdateEquipmentHandler), validatorResult);
            }

            var dataToUpdate = _mapper.Map<Domain.Equipment>(request);
            await _equipmentRepository.UpdateAsync(dataToUpdate, cancellationToken);
            _logger.LogDebug(Resources.Logger_Debug_EndHandler, nameof(Domain.Equipment), request.Guid);

            return Unit.Value;
        }
    }
}
