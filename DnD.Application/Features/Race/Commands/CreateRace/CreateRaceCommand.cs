using MediatR;

namespace DnD.Application.Features.Race.Commands.CreateRace
{
    public record CreateRaceCommand : IRequest<Unit>
    {
        public string Name { get; set; } = string.Empty;
    }
}
