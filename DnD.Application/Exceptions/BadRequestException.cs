using FluentValidation.Results;

namespace DnD.Application.Exceptions
{
    public class BadRequestException : Exception
    {
        public readonly List<string> Errors = new();

        public BadRequestException(string message, ValidationResult validationResult) : base(message)
        {
            foreach (var error in validationResult.Errors)
            {
                Errors.Add(error.ErrorMessage);
            }
        }
    }
}
