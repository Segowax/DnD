using MediatR;

namespace DnD.Application.Features.Equipment.Queries.GetEquipmentDetails
{
    public record GetEquipmentDetailsQuery(Guid Guid) : IRequest<GetEquipmentDetailsDto>;
}
