using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using ProjektZespołówka.DTOs.Create;

namespace ProjektZespołówka.Validators
{
    public class CreateMeasurmentsValidator : AbstractValidator<CreateMeasurmentsDto>
    {
        public CreateMeasurmentsValidator()
        {
            RuleFor(x => x.OutletId).NotEmpty().WithMessage("Outlet Id is required");
            RuleFor(x => x.ServiceWorkerId).NotEmpty().WithMessage("Service Worker Id is required");
            RuleFor(x => x.AttachmentId).NotEmpty().WithMessage("Attachment Id is required");
            RuleFor(x => x.Type).IsInEnum().WithMessage("Invalid Type");
            RuleFor(x => x.TechnicalDetails).NotEmpty().WithMessage("Technical Details are required");
            RuleFor(x => x.MeasuredAt).NotEmpty().WithMessage("Measured At is required");
            RuleFor(x => x.Certification).IsInEnum().WithMessage("Invalid Certification");
        }
    }
}