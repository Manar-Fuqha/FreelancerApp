using FluentValidation;
using FreelancerApp.Domain.DTOs.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerApp.Application.Validation.Project
{
    public class CreateProjectCommandValidator : AbstractValidator<CreateProjectRequestDto>
    {
        public CreateProjectCommandValidator()
        {
            ApplyCommonRulesFor(p => p.title, "Title");
            ApplyCommonRulesFor(p => p.description, "Description");
            ApplyCommonRulesFor(p => p.clientId, "ClientId");
        }

        private void ApplyCommonRulesFor<T>(Expression<Func<CreateProjectRequestDto, T>> expression, string propertyName)
        {
            RuleFor(expression)
                .NotEmpty().WithMessage($"{propertyName} cannot be empty.")
                .NotNull().WithMessage($"{propertyName} is required.");
        }
    }
}
