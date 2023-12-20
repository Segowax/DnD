using AutoMapper;
using DnD.Application.Contracts.Logging;
using DnD.Application.Contracts.Persistence;
using DnD.Application.Exceptions;
using DnD.Application.Properties;
using DnD.Common.Enums;
using MediatR;

namespace DnD.Application.Features.Equipment.Commands.CreateEquipment
{
    public class CreateEquipmentHandler : IRequestHandler<CreateEquipmentCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IAppLogger<CreateEquipmentHandler> _logger;
        private readonly IEquipmentRepository _equipmentRepository;

        public CreateEquipmentHandler(IMapper mapper,
            IEquipmentRepository equipmentRepository,
            IAppLogger<CreateEquipmentHandler> logger)
        {
            _mapper = mapper;
            _logger = logger;
            _equipmentRepository = equipmentRepository;
        }

        public async Task<Unit> Handle(CreateEquipmentCommand request, CancellationToken cancellationToken)
        {
            _logger.LogDebug(Resources.Logger_Debug_StartHandler, nameof(Crud.create), nameof(Domain.Equipment), request.Name);
            var validator = new CreateEquipmentValidator(_equipmentRepository);
            var validatorResult = await validator.ValidateAsync(request, cancellationToken);
            if (!validatorResult.IsValid)
            {
                _logger.LogWarning(Resources.Logger_Warning_Validator, nameof(Crud.create), nameof(Domain.Equipment), request.Name);
                throw new BadRequestException(nameof(CreateEquipmentHandler), validatorResult);
            }

            var dataToCreate = _mapper.Map<Domain.Equipment>(request);
            await _equipmentRepository.CreateAsync(dataToCreate, cancellationToken);
            _logger.LogDebug(Resources.Logger_Debug_EndHandler, nameof(Crud.create), nameof(Domain.Equipment), request.Name);

            return Unit.Value;
        }
    }
}
