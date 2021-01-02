using dotNetCoreMVCTelerikGrid.Models;
using dotNetCoreMVCTelerikGrid.Services.Abstraction;
using dotNetCoreMVCTelerikGrid.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetCoreMVCTelerikGrid.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryRepo _categoryRepo;
        public HomeController(ICategoryRepo categoryRepo) => _categoryRepo = categoryRepo;
        public IActionResult Index()
        {
            var vm = new HomeVM()
            {
                AllCategories = _categoryRepo.GetAllCategories
            };
            return View(vm);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
