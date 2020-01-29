using CarShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.ViewModels
{
    public class CarListViewModel
    {
        public IEnumerable<Car> GetAllCars { get; set; }

        public string CurrentCategory { get; set; }
    }
}
