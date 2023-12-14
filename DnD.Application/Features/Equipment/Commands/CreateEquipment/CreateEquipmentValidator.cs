using DnD.Application.Contracts.Persistence;
using DnD.Application.Properties;
using FluentValidation;

namespace DnD.Application.Features.Equipment.Commands.CreateEquipment
{
    public class CreateEquipmentValidator : AbstractValidator<CreateEquipmentCommand>
    {
        private readonly IEquipmentRepository _equipmentRepository;

        public CreateEquipmentValidator(IEquipmentRepository equipmentRepository)
        {
            _equipmentRepository = equipmentRepository;

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage(Resources.Validator_Required)
                .NotNull().WithMessage(Resources.Validator_Required)
                .MaximumLength(50).WithMessage(Resources.Validator_MaximumLength);

            RuleFor(p => p.Weight)
                .NotEmpty().WithMessage(Resources.Validator_Required)
                .NotNull().WithMessage(Resources.Validator_Required)
                .GreaterThanOrEqualTo(0).WithMessage(Resources.Validator_GreaterThanOrEqualTo);

            RuleFor(p => p.Description)
                .NotEmpty().WithMessage(Resources.Validator_Required)
                .NotNull().WithMessage(Resources.Validator_Required)
                .MaximumLength(250).WithMessage(Resources.Validator_MaximumLength);

            RuleFor(p => p)
                .MustAsync(IsEquipmentNameUnique).WithMessage(Resources.Validator_AlreadyExists);
        }

        private async Task<bool> IsEquipmentNameUnique(CreateEquipmentCommand command, CancellationToken cancellationToken) =>
            await _equipmentRepository.IsEquipmentNameUnique(command.Name, cancellationToken);

    }
}
