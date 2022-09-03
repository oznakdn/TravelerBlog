using Microsoft.AspNetCore.Mvc;
using TravelerBlog.Application.Repositories;

namespace TravelerBlog.WebUI.Components.LocationComponents
{
    public class RandomLocationsListComponent : ViewComponent
    {
        private readonly ILocationRepository _locationRepository;

        public RandomLocationsListComponent(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public IViewComponentResult Invoke()
        {
            var locations = _locationRepository.GetAllWithIncludeAndThanInclude(false).Result;
            var result = locations.OrderBy(l => l.Posts.Count).Take(3).ToList();
            return View(result);

        }
    }
}
