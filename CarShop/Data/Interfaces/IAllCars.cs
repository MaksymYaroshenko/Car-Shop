﻿using CarShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Car { get; }

        IEnumerable<Car> GetFavouriteCars { get; }

        Car GetObjectCar(int CarID);
    }
}
