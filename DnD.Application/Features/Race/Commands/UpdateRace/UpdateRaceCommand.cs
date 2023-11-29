using MediatR;

namespace DnD.Application.Features.Race.Commands.UpdateRace
{
    public class UpdateRaceCommand : IRequest<Unit>
    {
        public Guid Guid { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
