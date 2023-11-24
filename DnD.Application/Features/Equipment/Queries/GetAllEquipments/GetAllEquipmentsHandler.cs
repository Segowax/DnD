using AutoMapper;
using DnD.Application.Contracts.Persistence;
using MediatR;

namespace DnD.Application.Features.Equipment.Queries.GetAllEquipments
{
    public class GetAllEquipmentsHandler : IRequestHandler<GetAllEquipmentsQuery, IEnumerable<GetAllEquipmentsDto>>
    {
        private readonly IMapper _mapper;
        private readonly IEquipmentRepository _equipmentRepository;

        public GetAllEquipmentsHandler(IEquipmentRepository equipmentRepository, IMapper mapper)
        {
            _mapper = mapper;
            _equipmentRepository = equipmentRepository;
        }

        public async Task<IEnumerable<GetAllEquipmentsDto>> Handle(GetAllEquipmentsQuery request, CancellationToken cancellationToken)
        {
            var result = await _equipmentRepository.GetAllAsync(cancellationToken);

            return _mapper.Map<IEnumerable<GetAllEquipmentsDto>>(result);
        }
    }
}
