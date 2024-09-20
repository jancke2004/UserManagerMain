using FluentValidation;
using UserManager.Logic.DTOs.Users;

public class AddUserValidator : AbstractValidator<AddUser>
{
    public AddUserValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required")
            .Length(3, 100).WithMessage("Name must be between 3 and 100 characters.");

        RuleFor(x => x.ContactNo)
            .NotEmpty().WithMessage("Contact number is required")
            .Matches(@"^[0-9]*$").WithMessage("Contact number must be numeric")
            .Length(10, 15).WithMessage("Contact number must be between 10 and 15 digits.");

        RuleFor(x => x.Added_By)
            .NotEmpty().WithMessage("AddedBy is required");

        RuleFor(x => x.Updated_By)
            .NotEmpty().WithMessage("UpdatedBy is required");
    }
}
