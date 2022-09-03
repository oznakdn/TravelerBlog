using Microsoft.AspNetCore.Mvc;
using TravelerBlog.Application.Repositories;

namespace TravelerBlog.WebUI.Controllers
{
    public class LocationController : Controller
    {
        private readonly ILocationRepository _locationRepository;

        public LocationController(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult>GetLocationDetail(Guid id)
        {
            var location = await _locationRepository.GetAsync(false, x=>x.Id == id,l=>l.LocationPictures,l=>l.Country);
            return View(location);
        }
    }
}
