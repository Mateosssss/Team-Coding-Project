using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using ProjektZespołówka.DTOs.Create;

namespace ProjektZespołówka.Validators
{
    public class CreateNetworkRackValidator : AbstractValidator<CreateNetworkRackDto>
    {
        public CreateNetworkRackValidator()
        {
            RuleFor(x => x.ProjectId).NotEmpty().WithMessage("Project Id is required");
            RuleFor(x => x.Model).NotEmpty().WithMessage("Model is required");
            RuleFor(x => x.Size).NotEmpty().WithMessage("Size is required");
            RuleFor(x => x.Location).NotEmpty().WithMessage("Location is required");
            RuleFor(x => x.FrontViewImageId).NotEmpty().WithMessage("Front View Image Id is required");
            RuleFor(x => x.SideViewImageId).NotEmpty().WithMessage("Side View Image Id is required");
            RuleFor(x => x.RearViewImageId).NotEmpty().WithMessage("Rear View Image Id is required");
            RuleFor(x => x.InstallationDate).NotEmpty().WithMessage("Installation Date is required");
        }
    }
}