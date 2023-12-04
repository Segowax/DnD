using DnD.Application.Properties;
using FluentValidation;

namespace DnD.Application.Features.Common
{
    public abstract class DeleteValidator<T> : AbstractValidator<T> where T : DeleteCommand
    {
        public DeleteValidator()
        {
            RuleFor(p => p.Guid)
                .NotEmpty().WithMessage(Resources.Validator_Required)
                .NotNull().WithMessage(Resources.Validator_Required);
        }
    }
}
