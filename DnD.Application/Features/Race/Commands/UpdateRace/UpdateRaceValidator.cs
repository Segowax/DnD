using DnD.Application.Contracts.Persistence;
using DnD.Application.Properties;
using FluentValidation;

namespace DnD.Application.Features.Race.Commands.UpdateRace
{
    public class UpdateRaceValidator : AbstractValidator<UpdateRaceCommand>
    {

        private readonly IRaceRepository _raceRepository;

        public UpdateRaceValidator(IRaceRepository raceRepository)
        {
            _raceRepository = raceRepository;

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage(Resources.Validator_Required)
                .NotNull().WithMessage(Resources.Validator_Required)
                .MaximumLength(50).WithMessage(Resources.Validator_MaximumLength);

            RuleFor(p => p)
                .MustAsync(IsRaceExist).WithMessage(Resources.Validator_DoesNotExist);
        }

        private async Task<bool> IsRaceExist(UpdateRaceCommand command, CancellationToken token) =>
            await _raceRepository.IsItemExistAsync(command.Guid);
    }
}
