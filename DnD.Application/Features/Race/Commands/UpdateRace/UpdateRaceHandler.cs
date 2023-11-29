using AutoMapper;
using DnD.Application.Contracts.Persistence;
using MediatR;

namespace DnD.Application.Features.Race.Commands.UpdateRace
{
    public class UpdateRaceHandler : IRequestHandler<UpdateRaceCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IRaceRepository _raceRepsitory;

        public UpdateRaceHandler(IMapper mapper, IRaceRepository raceRepository)
        {
            _mapper = mapper;
            _raceRepsitory = raceRepository;
        }

        public async Task<Unit> Handle(UpdateRaceCommand request, CancellationToken cancellationToken)
        {
            var dataToUpdate = _mapper.Map<Domain.Race>(request);
            await _raceRepsitory.UpdateAsync(dataToUpdate, cancellationToken);

            return Unit.Value;
        }
    }
}
