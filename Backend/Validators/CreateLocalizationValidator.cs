using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using ProjektZespołówka.DTOs.Create;

namespace ProjektZespołówka.Validators
{
    public class CreateLocalizationValidator : AbstractValidator<CreateLocalizationDto>
    {
        public CreateLocalizationValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Address is required");
            RuleFor(x => x.ContactEmail).NotEmpty().EmailAddress().WithMessage("Valid Contact Email is required");
            RuleFor(x => x.ContactPhone).NotEmpty().WithMessage("Contact Phone is required");
        }
    }
}