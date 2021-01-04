using dotNetCoreMVCTelerikGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetCoreMVCTelerikGrid.Services.Abstraction
{
    public interface IPieRepo
    {
        //Create command
        void CreatePie(Pie pie);
        IEnumerable<Pie> GetAllPies { get; }
        IEnumerable<Pie> GetAllPiesOfTheWeek { get; }
        IEnumerable<Pie> GetPiesByCategory(string category);
        Pie GetPieById(int? id);
        //Update command
        void UpdatePie(Pie pie);
        //Delete command
        void DeletePie(Pie pie);
        void SaveChanges();

    }
}
