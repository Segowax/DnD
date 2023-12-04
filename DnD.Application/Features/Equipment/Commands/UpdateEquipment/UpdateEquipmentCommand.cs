using MediatR;

namespace DnD.Application.Features.Equipment.Commands.UpdateEquipment
{
    public class UpdateEquipmentCommand : IRequest<Unit>
    {
        public Guid Guid { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public float Weight { get; set; }
    }
}
