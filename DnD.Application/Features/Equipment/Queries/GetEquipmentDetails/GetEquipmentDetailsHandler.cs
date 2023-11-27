using AutoMapper;
using DnD.Application.Contracts.Persistence;
using MediatR;

namespace DnD.Application.Features.Equipment.Queries.GetEquipmentDetails
{
    public class GetEquipmentDetailsHandler : IRequestHandler<GetEquipmentDetailsQuery, GetEquipmentDetailsDto>
    {
        private readonly IMapper _mapper;
        private readonly IEquipmentRepository _equipmentRepository;

        public GetEquipmentDetailsHandler(IMapper mapper, IEquipmentRepository equipmentRepository)
        {
            _mapper = mapper;
            _equipmentRepository = equipmentRepository;
        }

        public async Task<GetEquipmentDetailsDto> Handle(GetEquipmentDetailsQuery request, CancellationToken cancellationToken)
        {
            var result = await _equipmentRepository.GetByGuidAsync(request.Guid);

            return _mapper.Map<GetEquipmentDetailsDto>(result);
        }
    }
}
