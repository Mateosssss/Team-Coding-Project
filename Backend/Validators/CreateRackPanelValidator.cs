using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using ProjektZespołówka.DTOs.Create;

namespace ProjektZespołówka.Validators
{
    public class CreateRackPanelValidator : AbstractValidator<CreateRackPanelDto>
    {
        public CreateRackPanelValidator()
        {
            RuleFor(x => x.NetworkRackId).NotEmpty().WithMessage("Network Rack Id is required");
            RuleFor(x => x.Type).NotEmpty().WithMessage("Type is required");
        }
    }
}