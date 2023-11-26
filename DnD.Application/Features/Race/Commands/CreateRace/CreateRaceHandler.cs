using AutoMapper;
using DnD.Application.Contracts.Persistence;
using MediatR;

namespace DnD.Application.Features.Race.Commands.CreateRace
{
    public class CreateRaceHandler : IRequestHandler<CreateRaceCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IRaceRepository _raceRepository;

        public CreateRaceHandler(IMapper mapper, IRaceRepository raceRepository)
        {
            _mapper = mapper;
            _raceRepository = raceRepository;
        }
        public async Task<Unit> Handle(CreateRaceCommand request, CancellationToken cancellationToken)
        {
            var dataToCreate = _mapper.Map<Domain.Race>(request);
            await _raceRepository.CreateAsync(dataToCreate, cancellationToken);

            return Unit.Value;
        }
    }
}
