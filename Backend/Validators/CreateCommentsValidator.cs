using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using ProjektZespołówka.DTOs.Create;

namespace ProjektZespołówka.Validators
{
    public class CreateCommentsValidator : AbstractValidator<CreateCommentsDto>
    {
        public CreateCommentsValidator()
        {
            RuleFor(x => x.EntityType).IsInEnum().WithMessage("Invalid Entity Type");
            RuleFor(x => x.EntityId).NotEmpty().WithMessage("Entity Id is required");
            RuleFor(x => x.AuthorId).NotEmpty().WithMessage("Author Id is required");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Content is required");
            RuleFor(x => x.Status).IsInEnum().WithMessage("Invalid Status");
            RuleFor(x => x.CreatedAt).NotEmpty().WithMessage("Created At is required");
        }
    }
}