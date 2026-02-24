using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using ProjektZespołówka.DTOs.Create;

namespace ProjektZespołówka.Validators
{
    public class CreateRoomValidator : AbstractValidator<CreateRoomDto>
    {
        public CreateRoomValidator()
        {
            RuleFor(x => x.LevelId).NotEmpty().WithMessage("Level Id is required");
            RuleFor(x => x.Number).GreaterThan(0).WithMessage("Number must be greater than 0");
            RuleFor(x => x.TechnicalName).NotEmpty().WithMessage("Technical Name is required");
            RuleFor(x => x.CoordinatesOnPlan).NotEmpty().WithMessage("Coordinates On Plan are required");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
        }
    }
}