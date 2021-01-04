using dotNetCoreMVCTelerikGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetCoreMVCTelerikGrid.Services.Abstraction
{
    public interface ICategoryRepo
    {
        IEnumerable<Category> GetAllCategories { get; }
        Category GetCategoryById(int id);
    }
}
