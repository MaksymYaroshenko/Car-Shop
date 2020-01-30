using CarShop.Data.Interfaces;
using CarShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Data.Repository
{
    public class CategoryRepository : ICarCategory
    {
        private readonly AppDBContext appDBContext;

        public CategoryRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<Category> AllCategories => appDBContext.Category;
    }
}
