﻿using dotNetCoreMVCTelerikGrid.Common.Context;
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
        public IEnumerable<Pie> GetAllPies => _db.Pies.Include(x => x.Category);
        public IEnumerable<Pie> GetAllPiesOfTheWeek => _db.Pies.Include(x => x.Category).Where(x => x.IsPieOfTheWeek);
        public Pie GetPieById(int id) => _db.Pies.FirstOrDefault(x => x.Id == id);

    }
}
