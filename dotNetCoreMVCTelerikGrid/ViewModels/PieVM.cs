using dotNetCoreMVCTelerikGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetCoreMVCTelerikGrid.ViewModels
{
    public class PieVM
    {
        public IEnumerable<Pie> Pies { get; set; }
        public Pie Pie { get; set; }
        public string CurrentCategory { get; set; }
    }
}
