﻿using System.Text.RegularExpressions;

namespace SimpraApi.Service.FluentValidators;

public class StaffUpdateRequestValidator : AbstractValidator<StaffUpdateRequest>
{
    public StaffUpdateRequestValidator()
    {
        RuleFor(x => x.FirstName)
                    .NotEmpty().WithMessage("Firstname cannot be empty.")
                    .MaximumLength(50).WithMessage("Firstname must be less than 50 character.");
        RuleFor(x => x.LastName)
                    .NotEmpty().WithMessage("Lastname cannot be empty.")
                    .MaximumLength(50).WithMessage("Lastname must be less than 50 character.");
        RuleFor(x => x.Email)
                    .EmailAddress(FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible).WithMessage("Invalid email format.")
                    .MaximumLength(64).WithMessage("Email must be less than 64 character.");
        RuleFor(x => x.Phone)
                    .Length(10, 15).WithMessage("Phone length must be 10-15 character.")
                    .Matches(new Regex(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}")).WithMessage("Invalid phone format");
        RuleFor(x => x.DateOfBirth)
                    .Must(root => root.CheckIfOlderThan18()).WithMessage("Staff must be at least 18 years old.");
        RuleFor(x => x.AddressLine)
                    .MaximumLength(50).WithMessage("Address line must be less than 50 character.");
        RuleFor(x => x.Country)
                    .NotEmpty().WithMessage("Country cannot be empty.")
                    .MaximumLength(20).WithMessage("Country must be less than 20 character.");
        RuleFor(x => x.City)
                    .MaximumLength(30).WithMessage("City must be less than 30 character.");
        RuleFor(x => x.Province)
                    .MaximumLength(30).WithMessage("Province must be less than 30 character.");
    }
}
