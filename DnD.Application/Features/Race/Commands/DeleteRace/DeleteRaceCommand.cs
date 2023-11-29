using MediatR;

namespace DnD.Application.Features.Race.Commands.DeleteRace
{
    public class DeleteRaceCommand : IRequest<Unit>
    {
        public Guid Guid { get; set; }
    }
}
