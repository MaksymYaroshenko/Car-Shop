using CarShop.Data.Models;
using System.Collections.Generic;

namespace CarShop.ViewModels
{
    public class CarListViewModel
    {
        public IEnumerable<Car> GetAllCars { get; set; }

        public string CurrentCategory { get; set; }
    }
}
