using AutoMapper;
using DnD.Application.Contracts.Logging;
using DnD.Application.Contracts.Persistence;
using DnD.Application.Properties;
using DnD.Common.Enums;
using MediatR;

namespace DnD.Application.Features.Equipment.Queries.GetAllEquipments
{
    public class GetAllEquipmentsHandler : IRequestHandler<GetAllEquipmentsQuery, IEnumerable<GetAllEquipmentsDto>>
    {
        private readonly IMapper _mapper;
        private readonly IAppLogger<GetAllEquipmentsHandler> _logger;
        private readonly IEquipmentRepository _equipmentRepository;

        public GetAllEquipmentsHandler(IMapper mapper,
            IAppLogger<GetAllEquipmentsHandler> logger,
            IEquipmentRepository equipmentRepository)
        {
            _mapper = mapper;
            _logger = logger;
            _equipmentRepository = equipmentRepository;
        }

        public async Task<IEnumerable<GetAllEquipmentsDto>> Handle(GetAllEquipmentsQuery request, CancellationToken cancellationToken)
        {
            _logger.LogDebug(Resources.Logger_Debug_StartHandler, nameof(Crud.read), nameof(Domain.Equipment), nameof(GetAllEquipmentsQuery));
            var result = await _equipmentRepository.GetAllAsync(cancellationToken);
            _logger.LogDebug(Resources.Logger_Debug_EndHandler, nameof(Crud.read), nameof(Domain.Equipment), nameof(GetAllEquipmentsQuery));

            return _mapper.Map<IEnumerable<GetAllEquipmentsDto>>(result);
        }
    }
}
