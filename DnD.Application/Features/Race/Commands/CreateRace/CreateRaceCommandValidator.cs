using DnD.Application.Contracts.Persistence;
using DnD.Application.Properties;
using FluentValidation;

namespace DnD.Application.Features.Race.Commands.CreateRace
{
    public class CreateRaceCommandValidator : AbstractValidator<CreateRaceCommand>
    {
        private readonly IRaceRepository _raceRepository;

        public CreateRaceCommandValidator(IRaceRepository raceRepository)
        {
            _raceRepository = raceRepository;

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage(Resources.Validator_Required)
                .NotNull().WithMessage(Resources.Validator_Required)
                .MaximumLength(50).WithMessage(Resources.Validator_MaximumLength);

            RuleFor(p => p)
                .MustAsync(IsRaceUnique).WithMessage(Resources.Validator_AlreadyExists);
        }

        private async Task<bool> IsRaceUnique(CreateRaceCommand createRaceCommand, CancellationToken cancellationToken) =>
            await _raceRepository.IsRaceUnique(createRaceCommand.Name, cancellationToken);
    }
}
