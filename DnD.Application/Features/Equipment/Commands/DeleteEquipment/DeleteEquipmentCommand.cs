using DnD.Application.Features.Common;
using MediatR;

namespace DnD.Application.Features.Equipment.Commands.DeleteEquipment
{
    public class DeleteEquipmentCommand : DeleteCommand, IRequest<Unit> {
        public DeleteEquipmentCommand() : base() { }
    }
}
