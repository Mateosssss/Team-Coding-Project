using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using ProjektZespołówka.DTOs.Create;

namespace ProjektZespołówka.Validators
{
    public class CreateLevelsValidator : AbstractValidator<CreateLevelsDto>
    {
        public CreateLevelsValidator()
        {
            RuleFor(x => x.ProjectId).NotEmpty().WithMessage("Project Id is required");
            RuleFor(x => x.LevelNumber).GreaterThan(0).WithMessage("Level Number must be greater than 0");
            RuleFor(x => x.TechnicalDescription).NotEmpty().WithMessage("Technical Description is required");
            RuleFor(x => x.CableType).NotEmpty().WithMessage("Cable Type is required");
            RuleFor(x => x.LevelPlanFileAttachmentId).NotEmpty().WithMessage("Level Plan File Attachment Id is required");
            RuleFor(x => x.CreatedAt).NotEmpty().WithMessage("Created At is required");
        }
    }
}