using CarShop.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Data
{
    public class DBObjects
    {
        private static Dictionary<string, Category> category;

        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(content => content.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car { Name = "Tesla", Image = "/image/tesla.jpg", LongDescription = "Long description", ShortDescription = "Short description", IsFavourite = true, Available = true, Category = Categories["Electrocar"], Price = 20000 },
                    new Car { Name = "Audi", Image = "/image/Audi_A7.jpg", LongDescription = "Long description", ShortDescription = "Short description", IsFavourite = false, Available = true, Category = Categories["Classic cars"], Price = 12000 },
                    new Car { Name = "Audi 2", Image = "/image/Audi_A7.jpg", LongDescription = "Long description", ShortDescription = "Short description", IsFavourite = false, Available = true, Category = Categories["Classic cars"], Price = 12000 },
                    new Car { Name = "Audi 3", Image = "/image/Audi_A7.jpg", LongDescription = "Long description", ShortDescription = "Short description", IsFavourite = false, Available = true, Category = Categories["Classic cars"], Price = 12000 }
                    );
            }
            content.SaveChanges();
        }

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { CategoryName = "Electrocar", Description = "Modern type of transport" },
                        new Category { CategoryName = "Classic cars", Description = "Traditional type of transport" }
                    };

                    category = new Dictionary<string, Category>();

                    foreach (var c in list)
                        category.Add(c.CategoryName, c);
                }

                return category;
            }
        }


    }
}
