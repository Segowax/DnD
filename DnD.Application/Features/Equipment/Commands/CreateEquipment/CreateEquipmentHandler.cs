using AutoMapper;
using DnD.Application.Contracts.Persistence;
using DnD.Application.Exceptions;
using DnD.Application.Features.Race.Commands.CreateRace;
using MediatR;

namespace DnD.Application.Features.Equipment.Commands.CreateEquipment
{
    public class CreateEquipmentHandler : IRequestHandler<CreateEquipmentCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IEquipmentRepository _equipmentRepository;

        public CreateEquipmentHandler(IMapper mapper, IEquipmentRepository equipmentRepository)
        {
            _mapper = mapper;
            _equipmentRepository = equipmentRepository;
        }

        public async Task<Unit> Handle(CreateEquipmentCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateEquipmentCommandValidator();
            var validatorResult = await validator.ValidateAsync(request, cancellationToken);
            if (!validatorResult.IsValid) throw new BadRequestException(nameof(CreateEquipmentHandler), validatorResult);

            var dataToCreate = _mapper.Map<Domain.Equipment>(request);
            await _equipmentRepository.CreateAsync(dataToCreate, cancellationToken);

            return Unit.Value;
        }
    }
}
