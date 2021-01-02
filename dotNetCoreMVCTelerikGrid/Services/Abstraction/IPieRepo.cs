using dotNetCoreMVCTelerikGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetCoreMVCTelerikGrid.Services.Abstraction
{
    public interface IPieRepo
    {
        IEnumerable<Pie> GetAllPies { get; }
        IEnumerable<Pie> GetAllPiesOfTheWeek { get; }
        Pie GetPieById(int id);
    }
}
