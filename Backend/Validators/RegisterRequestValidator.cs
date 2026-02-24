using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.Validators
{
    public class RegisterRequestValidator:AbstractValidator<UserDtoRegister>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required")
                                 .EmailAddress().WithMessage("Invalid email format");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required")
                                    .MinimumLength(6).WithMessage("Password must be at least 6 characters long");
            RuleFor(x=>x.Name_Surname).NotEmpty().WithMessage("Name and Surname are required");
        }
    }
}