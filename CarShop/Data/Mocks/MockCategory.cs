using CarShop.Data.Interfaces;
using CarShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Data.Mocks
{
    public class MockCategory : ICarCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { Id = 0 ,CategoryName = "Electrocar", Description = "Modern type of transport" },
                    new Category { Id = 1, CategoryName = "Classic cars", Description = "Traditional type of transport" }
                };
            }
        }
    }
}
