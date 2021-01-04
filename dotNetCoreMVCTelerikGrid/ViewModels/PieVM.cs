using dotNetCoreMVCTelerikGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetCoreMVCTelerikGrid.ViewModels
{
    public class PieVM
    {
        public int Id { get; set; }
        public IEnumerable<Pie> Pies { get; set; }
        public Pie Pie { get; set; }
        public string CurrentCategory { get; set; }
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public decimal Price { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
