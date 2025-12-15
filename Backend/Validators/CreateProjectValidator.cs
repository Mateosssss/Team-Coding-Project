using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using ProjektZespołówka.DTOs.Create;

namespace ProjektZespołówka.Validators
{
    public class CreateProjectValidator : AbstractValidator<CreateProjectDto>
    {
        public CreateProjectValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title is required");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
            RuleFor(x => x.ContactPhone).NotEmpty().WithMessage("Contact Phone is required");
            RuleFor(x => x.ContactEmail).NotEmpty().EmailAddress().WithMessage("Valid Contact Email is required");
            RuleFor(x => x.ManagerId).NotEmpty().WithMessage("Manager Id is required");
            RuleFor(x => x.InvestorId).NotEmpty().WithMessage("Investor Id is required");
            RuleFor(x => x.LocationId).NotEmpty().WithMessage("Location Id is required");
        }
    }
}