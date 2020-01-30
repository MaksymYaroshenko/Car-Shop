using CarShop.Data.Interfaces;
using CarShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContext appDBContext;

        public CarRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<Car> Car => appDBContext.Car.Include(c => c.Category);

        public IEnumerable<Car> GetFavouriteCars => appDBContext.Car.Where(p => p.IsFavourite).Include(c => c.Category);

        public Car GetObjectCar(int CarID) => appDBContext.Car.FirstOrDefault(p => p.Id == CarID); 
    }
}
