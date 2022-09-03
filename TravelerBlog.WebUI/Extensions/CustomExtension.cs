using FluentValidation;
using TravelerBlog.Application.Repositories;
using TravelerBlog.Application.Validations.AdviceValidators;
using TravelerBlog.Application.Validations.CityValidators;
using TravelerBlog.Application.Validations.CountryVaidators;
using TravelerBlog.Core.Dtos.AdviceDtos;
using TravelerBlog.Core.Dtos.CityDtos;
using TravelerBlog.Core.Dtos.CountryDto;
using TravelerBlog.Persistence.Repositories;

namespace TravelerBlog.WebUI.Extensions
{
    public static class CustomExtension
    {
        public static IServiceCollection AddIocContainer(this IServiceCollection services)
        {
            services.AddScoped<IAdviceRepository, AdviceRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();

            return services;
        }

        public static IServiceCollection AddFluentValidationContainer (this IServiceCollection services)
        {
            services.AddScoped<IValidator<CreateAdviceDto>, CreateAdviceValidator>();
            services.AddScoped<IValidator<CreateCountryDto>, CreateCountryValidator>();
            services.AddScoped<IValidator<CreateCityDto>, CreateCityValidator>();

            return services;
        }
       

    }
}
