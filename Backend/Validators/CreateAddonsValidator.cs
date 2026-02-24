using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using ProjektZespołówka.DTOs.Create;

namespace ProjektZespołówka.Validators
{
    public class CreateAddonsValidator : AbstractValidator<CreateAddonsDto>
    {
        public CreateAddonsValidator()
        {
            RuleFor(x => x.EntityType).NotEmpty().WithMessage("Entity Type is required");
            RuleFor(x => x.EntityId).NotEmpty().WithMessage("Entity Id is required");
            RuleFor(x => x.FileAttachmentId).NotEmpty().WithMessage("File Attachment Id is required");
            RuleFor(x => x.UploadedByUserId).NotEmpty().WithMessage("Uploaded By User Id is required");
        }
    }
}