using CarShop.Data.Interfaces;
using CarShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    public class CarController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarCategory _allCategories;

        public CarController(IAllCars allCars, ICarCategory carCategory)
        {
            _allCars = allCars;
            _allCategories = carCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Page with automobiles";
            CarListViewModel carListViewModel = new CarListViewModel
            {
                GetAllCars = _allCars.Car,
                CurrentCategory = "Automobiles"
            };

            return View(carListViewModel);
        }
    }
}
