using CarShop.Data.Interfaces;
using CarShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Data.Mocks
{
    public class MockCar : IAllCars
    {
        private readonly ICarCategory _carCategory = new MockCategory();

        public IEnumerable<Car> Cars 
        {
            get
            {
                return new List<Car>
                {
                    new Car { Name = "Tesla", Id = 0, LongDescription = "Long description", ShortDescription = "Short description", IsFavourite = true, Available = true, Category = _carCategory.AllCategories.First()}
                };
            }
        }

        public IEnumerable<Car> GetFavouriteCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car GetObjectCar(int CarID)
        {
            throw new NotImplementedException();
        }
    }
}
