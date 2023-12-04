using AutoMapper;
using DnD.Application.Contracts.Persistence;
using DnD.Application.Exceptions;
using MediatR;

namespace DnD.Application.Features.Equipment.Commands.UpdateEquipment
{
    public class UpdateEquipmentHandler : IRequestHandler<UpdateEquipmentCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IEquipmentRepository _equipmentRepository;

        public UpdateEquipmentHandler(IMapper mapper, IEquipmentRepository equipmentRepository)
        {
            _mapper = mapper;
            _equipmentRepository = equipmentRepository;
        }

        public async Task<Unit> Handle(UpdateEquipmentCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateEquipmentValidator(_equipmentRepository);
            var validatorResult = await validator.ValidateAsync(request, cancellationToken);
            if (!validatorResult.IsValid) throw new BadRequestException(nameof(UpdateEquipmentHandler), validatorResult);

            var dataToUpdate = _mapper.Map<Domain.Equipment>(request);
            await _equipmentRepository.UpdateAsync(dataToUpdate, cancellationToken);

            return Unit.Value;
        }
    }
}
