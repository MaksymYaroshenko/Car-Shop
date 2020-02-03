using CarShop.Data.Interfaces;
using CarShop.Data.Models;
using System.Collections.Generic;

namespace CarShop.Data.Repository
{
    public class CategoryRepository : ICarCategory
    {
        private readonly AppDBContent appDBContext;

        public CategoryRepository(AppDBContent appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<Category> AllCategories => appDBContext.Category;
    }
}
