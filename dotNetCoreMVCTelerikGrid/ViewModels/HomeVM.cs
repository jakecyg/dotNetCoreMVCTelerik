using dotNetCoreMVCTelerikGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetCoreMVCTelerikGrid.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Category> AllCategories { get; set; }
    }
}
