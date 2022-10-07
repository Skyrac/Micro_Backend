using UserDomain.Contracts.DTO;
using FluentValidation;

namespace UserDomain.Core.Validators
{
    public class ValidateUserDTOValidator : AbstractValidator<ValidateUserDTO>
    {
        public ValidateUserDTOValidator()
        {
            RuleFor(x => x.EmailAddress).NotEmpty().WithMessage("EmailAddress is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required");
            RuleFor(x => x.EmailAddress).EmailAddress().WithMessage("Not a valid EmailAddress");
        }
    }
}
