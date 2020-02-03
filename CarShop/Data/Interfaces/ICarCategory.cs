using CarShop.Data.Models;
using System.Collections.Generic;

namespace CarShop.Data.Interfaces
{
    public interface ICarCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
