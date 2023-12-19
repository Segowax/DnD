using AutoMapper;
using DnD.Application.Contracts.Logging;
using DnD.Application.Contracts.Persistence;
using DnD.Application.Properties;
using DnD.Common.Enums;
using MediatR;

namespace DnD.Application.Features.Equipment.Queries.GetEquipmentDetails
{
    public class GetEquipmentDetailsHandler : IRequestHandler<GetEquipmentDetailsQuery, GetEquipmentDetailsDto>
    {
        private readonly IMapper _mapper;
        private readonly IAppLogger<GetEquipmentDetailsHandler> _logger;
        private readonly IEquipmentRepository _equipmentRepository;

        public GetEquipmentDetailsHandler(IMapper mapper,
            IAppLogger<GetEquipmentDetailsHandler> logger,
            IEquipmentRepository equipmentRepository)
        {
            _mapper = mapper;
            _logger = logger;
            _equipmentRepository = equipmentRepository;
        }

        public async Task<GetEquipmentDetailsDto> Handle(GetEquipmentDetailsQuery request, CancellationToken cancellationToken)
        {
            _logger.LogDebug(Resources.Logger_Debug_StartHandler, nameof(Crud.read), nameof(Domain.Equipment), request.Guid);
            var result = await _equipmentRepository.GetByGuidAsync(request.Guid);
            _logger.LogDebug(Resources.Logger_Debug_EndHandler, nameof(Crud.read), nameof(Domain.Equipment), request.Guid);

            return _mapper.Map<GetEquipmentDetailsDto>(result);
        }
    }
}
