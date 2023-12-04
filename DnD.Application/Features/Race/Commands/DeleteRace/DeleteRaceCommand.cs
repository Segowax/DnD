using DnD.Application.Features.Common;
using MediatR;

namespace DnD.Application.Features.Race.Commands.DeleteRace
{
    public class DeleteRaceCommand : DeleteCommand, IRequest<Unit> { }
}
