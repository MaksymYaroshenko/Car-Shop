using CarShop.Data.Interfaces;
using CarShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    public class HomeController : Controller
    {
        private IAllCars _carRepository;

        public HomeController(IAllCars allCars)
        {
            _carRepository = allCars;
        }

        public ViewResult Index()
        {
            ViewBag.Title = "Home Page";
            var homeCars = new HomeViewModel
            {
                FavouriteCars = _carRepository.GetFavouriteCars
            };
            return View(homeCars);
        }
    }
}
