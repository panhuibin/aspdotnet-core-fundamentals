using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        private ICuisineData _cuisineData;

        public CuisineController(ICuisineData cuisineData)
        {
            _cuisineData = cuisineData;
        }

        public IActionResult Index()
        {
            var model = _cuisineData.GetAll();

            return View(model);
        }
    }
}
