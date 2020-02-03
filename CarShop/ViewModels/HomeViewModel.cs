using CarShop.Data.Models;
using System.Collections.Generic;

namespace CarShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> FavouriteCars { get; set; }
    }
}
