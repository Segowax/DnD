using MediatR;

namespace DnD.Application.Features.Equipment.Commands.CreateEquipment
{
    public class CreateEquipmentCommand :IRequest<Unit>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public float Weight { get; set; }
    }
}
