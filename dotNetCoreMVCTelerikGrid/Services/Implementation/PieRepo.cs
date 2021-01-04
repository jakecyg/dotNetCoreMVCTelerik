using dotNetCoreMVCTelerikGrid.Common.Context;
using dotNetCoreMVCTelerikGrid.Models;
using dotNetCoreMVCTelerikGrid.Services.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetCoreMVCTelerikGrid.Services.Implementation
{
    public class PieRepo : IPieRepo
    {
        private readonly dbContext _db;
        public PieRepo(dbContext db) => _db = db;
        public void CreatePie(Pie pie)
        {
            if (pie == null) throw new ArgumentNullException(nameof(pie));
            _db.Pies.Add(pie);
            var created = _db.SaveChanges();
        }
        public IEnumerable<Pie> GetAllPies => _db.Pies.Include(x => x.Category);
        public IEnumerable<Pie> GetAllPiesOfTheWeek => _db.Pies.Include(x => x.Category).Where(x => x.IsPieOfTheWeek);
        public IEnumerable<Pie> GetPiesByCategory(string category) => _db.Pies.Include(x => x.Category).Where(x => x.Category.CategoryName == category);
        public Pie GetPieById(int? id) => _db.Pies.FirstOrDefault(x => x.Id == id);
        public void DeletePie(Pie pie)
        {
            if (pie == null) throw new ArgumentNullException(nameof(pie));
            _db.Pies.Remove(pie);
            _db.SaveChanges();
        }
        public void UpdatePie(Pie pie)
        {
            if (pie == null) throw new ArgumentNullException(nameof(pie));
            _db.Pies.Update(pie);
            _db.SaveChanges();
        }
        public void SaveChanges() => _db.SaveChanges();

    }
}
