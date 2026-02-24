using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektZespołówka.DTOs.Create;
using FluentValidation;

namespace ProjektZespołówka.Validators
{
    public class CreateWorkStagesValidator:AbstractValidator<CreateWorkStagesDto>
    {
        public CreateWorkStagesValidator()
        {
            RuleFor(x => x.StageName).NotEmpty().WithMessage("Stage Name is required");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
            RuleFor(x => x.Deadline).GreaterThan(DateTime.Now).WithMessage("Deadline must be a future date");
            RuleFor(x => x.AssignedUserId).NotEmpty().WithMessage("Assigned User Id is required");
        }
    }
}