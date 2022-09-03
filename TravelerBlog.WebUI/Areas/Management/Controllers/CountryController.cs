using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using TravelerBlog.Application.Repositories;
using TravelerBlog.Core.Dtos.CountryDto;

namespace TravelerBlog.WebUI.Areas.Management.Controllers
{
    public class CountryController : Controller
    {

        private readonly ICountryRepository _countryRepository;
        private readonly IValidator<CreateCountryDto> _validator;

        public CountryController(ICountryRepository countryRepository, IValidator<CreateCountryDto> validator)
        {
            _countryRepository = countryRepository;
            _validator = validator;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddCountry()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCountry(CreateCountryDto createCountry)
        {
            ValidationResult result = await _validator.ValidateAsync(createCountry);

            Country country = new()
            {
                CountryName = createCountry.CountryName,
                Description = createCountry.Description
            };

            if (!result.IsValid)
            {
                result.AddState(this.ModelState);
                return View(nameof(Index), createCountry);
            }

            await _countryRepository.AddAsync(country);
            return RedirectToAction("Index","Home");
        }
    }
}
