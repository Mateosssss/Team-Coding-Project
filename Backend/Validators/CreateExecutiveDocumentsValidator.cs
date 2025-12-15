using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using ProjektZespołówka.DTOs.Create;

namespace ProjektZespołówka.Validators
{
    public class CreateExecutiveDocumentsValidator : AbstractValidator<CreateExecutiveDocumentsDto>
    {
        public CreateExecutiveDocumentsValidator()
        {
            RuleFor(x => x.ProjectId).NotEmpty().WithMessage("Project Id is required");
            RuleFor(x => x.DocumentId).NotEmpty().WithMessage("Document Id is required");
            RuleFor(x => x.UploadedAt).NotEmpty().WithMessage("Uploaded At is required");
            RuleFor(x => x.RecipientId).NotEmpty().WithMessage("Recipient Id is required");
        }
    }
}