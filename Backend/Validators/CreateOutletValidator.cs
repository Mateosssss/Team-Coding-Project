using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using ProjektZespołówka.DTOs.Create;

namespace ProjektZespołówka.Validators
{
    public class CreateOutletValidator : AbstractValidator<CreateOutletDto>
    {
        public CreateOutletValidator()
        {
            RuleFor(x => x.RoomId).NotEmpty().WithMessage("Room Id is required");
            RuleFor(x => x.ServedById).NotEmpty().WithMessage("Served By Id is required");
            RuleFor(x => x.TechnicalName).NotEmpty().WithMessage("Technical Name is required");
            RuleFor(x => x.Type).IsInEnum().WithMessage("Invalid Type");
            RuleFor(x => x.NearPhotoId).NotEmpty().WithMessage("Near Photo Id is required");
            RuleFor(x => x.FarPhotoId).NotEmpty().WithMessage("Far Photo Id is required");
        }
    }
}