using FluentValidation;
using FreelancerApp.Domain.DTOs.Freelancers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerApp.Application.Validation.Freelancer
{
    public class CreateFreelancerCommandValidator : AbstractValidator<CreateFreelancerDto>
    {
        public CreateFreelancerCommandValidator()
        {

            RuleFor(f => f.name)
                 .NotEmpty().WithMessage("Name cannot be empty.")
                 .NotNull().WithMessage("Name is required.");


            RuleFor(f => f.email)
                .EmailAddress()
                .NotEmpty().WithMessage("Email cannot be empty.")
                .NotNull().WithMessage("Email is required.");

            RuleFor(f => f.skillSet)
                .MinimumLength(5).WithMessage("The min length is 5")
                .NotEmpty().WithMessage("Skill Set cannot be empty.")
                .NotNull().WithMessage("Skill Set is required.");


            RuleFor(f => f.hourlyRate)
               .NotEmpty().WithMessage("Hourly Rate cannot be empty.")
               .NotNull().WithMessage("Hourly Rate is required.")
               .GreaterThan(0).WithMessage("Hourly Rate must be greater than 0.");



        }
    }
}
