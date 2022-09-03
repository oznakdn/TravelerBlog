using Microsoft.AspNetCore.Mvc;
using TravelerBlog.Application.Repositories;

namespace TravelerBlog.WebUI.Components.CountryComponents
{
    public class CountriesListComponent : ViewComponent
    {
        private readonly ICountryRepository countryRepositorcy;

        public CountriesListComponent(ICountryRepository countryRepositorcy)
        {
            this.countryRepositorcy = countryRepositorcy;
        }

        public IViewComponentResult Invoke()
        {
            var coutries =countryRepositorcy.GetAllAsync(false).Result;
            var result = coutries.ToList();
            return View(result);
        }
    }
}
