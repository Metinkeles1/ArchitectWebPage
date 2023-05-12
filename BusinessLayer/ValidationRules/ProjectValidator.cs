using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ProjectValidator : AbstractValidator<Project>
    {
        public ProjectValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("project name cannot be empty");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("ImageUrl cannot be empty");
            RuleFor(x => x.ImageUrlSmall).NotEmpty().WithMessage("Small Image Url cannot be empty");
            RuleFor(x => x.ProjectUrl).NotEmpty().WithMessage("ImageUrl cannot be empty");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Project name must be at least 5 characters");
            
        }
    }
}