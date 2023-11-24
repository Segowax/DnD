using MediatR;

namespace DnD.Application.Features.Equipment.Queries.GetAllEquipments
{
    public record GetAllEquipmentsQuery : IRequest<IEnumerable<GetAllEquipmentsDto>>;
}
