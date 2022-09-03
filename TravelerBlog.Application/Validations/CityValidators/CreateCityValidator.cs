using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelerBlog.Core.Dtos.CityDtos;

namespace TravelerBlog.Application.Validations.CityValidators
{
    public class CreateCityValidator:AbstractValidator<CreateCityDto>
    {
        public CreateCityValidator()
        {
            RuleFor(c => c.CityName).NotEmpty().NotNull();
            RuleFor(c => c.Description).NotEmpty().NotNull().MinimumLength(20).MaximumLength(300);

        }
    }
}
