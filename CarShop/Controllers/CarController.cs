using CarShop.Data.Interfaces;
using CarShop.Data.Models;
using CarShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarShop.Controllers
{
    public class CarController : Controller
    {
        private readonly IAllCars __allCars;
        private readonly ICarCategory __allCategories;

        public CarController(IAllCars allCars, ICarCategory carCategory)
        {
            __allCars = allCars;
            __allCategories = carCategory;
        }

        [Route("Car/List")]
        [Route("Car/List/{category}")]
        public ViewResult List(string category)
        {
            IEnumerable<Car> cars = null;
            string currentCategory = string.Empty;
            if (string.IsNullOrEmpty(category))
            {
                cars = __allCars.Car.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = __allCars.Car.Where(i => i.Category.CategoryName.Equals("Electrocar")).OrderBy(i => i.Id);
                    currentCategory = "Electrocar";
                }
                else
                {
                    cars = __allCars.Car.Where(i => i.Category.CategoryName.Equals("Classic cars")).OrderBy(i => i.Id);
                    currentCategory = "Classic cars";
                }
            }

            ViewBag.Title = "Page with automobiles";
            CarListViewModel carListViewModel = new CarListViewModel
            {
                GetAllCars = cars,
                CurrentCategory = currentCategory
            };

            return View(carListViewModel);
        }
    }
}
