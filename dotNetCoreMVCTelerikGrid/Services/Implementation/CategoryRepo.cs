using dotNetCoreMVCTelerikGrid.Common.Context;
using dotNetCoreMVCTelerikGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetCoreMVCTelerikGrid.Services.Implementation
{
    public class CategoryRepo
    {
        private readonly dbContext _db;
        public CategoryRepo(dbContext db) => _db = db;
        public IEnumerable<Category> GetAllCategories => _db.Categories;
    }
}
