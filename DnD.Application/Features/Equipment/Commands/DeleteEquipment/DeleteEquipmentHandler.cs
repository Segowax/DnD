using AutoMapper;
using DnD.Application.Contracts.Persistence;
using DnD.Application.Exceptions;
using MediatR;

namespace DnD.Application.Features.Equipment.Commands.DeleteEquipment
{
    public class DeleteEquipmentHandler : IRequestHandler<DeleteEquipmentCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IEquipmentRepository _equipmentRepository;

        public DeleteEquipmentHandler(IMapper mapper, IEquipmentRepository raceRepository)
        {
            _mapper = mapper;
            _equipmentRepository = raceRepository;
        }

        public async Task<Unit> Handle(DeleteEquipmentCommand request, CancellationToken cancellationToken)
        {
            var validator = new DeleteEquipmentValidator();
            var validatorResult = await validator.ValidateAsync(request, cancellationToken);
            if (!validatorResult.IsValid) throw new BadRequestException(nameof(DeleteEquipmentHandler), validatorResult);

            var dataToDelete = _mapper.Map<Domain.Equipment>(request);
            if (dataToDelete == null)
                throw new NotFoundException(nameof(Race), request.Guid);
            await _equipmentRepository.DeleteAsync(dataToDelete, cancellationToken);

            return Unit.Value;
        }
    }
}
