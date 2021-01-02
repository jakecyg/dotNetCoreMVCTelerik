using dotNetCoreMVCTelerikGrid.Models;
using dotNetCoreMVCTelerikGrid.Services.Abstraction;
using dotNetCoreMVCTelerikGrid.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetCoreMVCTelerikGrid.Controllers
{
    public class PiesController : Controller
    {
        private readonly IPieRepo _pieRepo;
        public PiesController(IPieRepo pieRepo) => _pieRepo = pieRepo;
        public ViewResult PieList (string category)
        {
            IEnumerable<Pie> pies;
            pies = category == null ? _pieRepo.GetAllPies : _pieRepo.GetAllPies.Where(x => x.Category.CategoryName == category);
            var vm = new PieVM
            {
                Pies = pies
            };
            return View(vm);
        }
    }

}
