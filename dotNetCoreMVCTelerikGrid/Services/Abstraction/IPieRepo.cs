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
        bool CreateCommand(Pie pie);
        IEnumerable<Pie> GetAllPies { get; }
        IEnumerable<Pie> GetAllPiesOfTheWeek { get; }
        IEnumerable<Pie> GetPiesByCategory(string category);
        Pie GetPieById(int id);
        //Update command
        bool UpdateCommand(Pie pie);
        //Delete command
        bool DeleteCommand(Pie pie);
        bool SaveChanges();

    }
}
