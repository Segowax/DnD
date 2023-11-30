﻿using AutoMapper;
using DnD.Application.Contracts.Persistence;
using DnD.Application.Exceptions;
using MediatR;

namespace DnD.Application.Features.Race.Commands.DeleteRace
{
    public class DeleteRaceHandler : IRequestHandler<DeleteRaceCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IRaceRepository _raceRepository;

        public DeleteRaceHandler(IMapper mapper, IRaceRepository raceRepository)
        {
            _mapper = mapper;
            _raceRepository = raceRepository;
        }

        public async Task<Unit> Handle(DeleteRaceCommand request, CancellationToken cancellationToken)
        {
            var dataToDelete = _mapper.Map<Domain.Race>(request);
            if (dataToDelete == null)
                throw new NotFoundException(nameof(Race), request.Guid);
            await _raceRepository.DeleteAsync(dataToDelete, cancellationToken);

            return Unit.Value;
        }
    }
}
