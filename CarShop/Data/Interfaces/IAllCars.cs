using CarShop.Data.Models;
using System.Collections.Generic;

namespace CarShop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Car { get; }

        IEnumerable<Car> GetFavouriteCars { get; }

        Car GetObjectCar(int CarID);
    }
}
