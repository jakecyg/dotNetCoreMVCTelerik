using dotNetCoreMVCTelerikGrid.Models;
using dotNetCoreMVCTelerikGrid.Services.Abstraction;
using dotNetCoreMVCTelerikGrid.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetCoreMVCTelerikGrid.Controllers
{
    public class PiesController : Controller
    {
        private readonly IPieRepo _pieRepo;
        private readonly ICategoryRepo _categoryRepo;
        public PiesController(IPieRepo pieRepo, ICategoryRepo categoryRepo)
        {
            _pieRepo = pieRepo;
            _categoryRepo = categoryRepo;
        }

        public ViewResult PieList(int categoryId)
        {
            var pies = categoryId == 0 ? _pieRepo.GetAllPies : _pieRepo.GetAllPies.Where(x => x.CategoryId == categoryId);
            var vm = new PieVM
            {
                Pies = pies,
                CategoryId = categoryId,
                Category = _categoryRepo.GetCategoryById(categoryId)
            };
            return View(vm);
        }

        public IActionResult Create(int categoryId)
        {
            var vm = new PieVM
            {
                CategoryId = categoryId,
                Category = _categoryRepo.GetCategoryById(categoryId),
                Categories = _categoryRepo.GetAllCategories
            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Price,ShortDesc,CategoryId")] Pie pie)
        {
            if (ModelState.IsValid)
            {
                _pieRepo.CreatePie(pie);
                return RedirectToAction("PieList", new { categoryId = pie.CategoryId });
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var pie = _pieRepo.GetPieById(id);
            if (pie == null) return NotFound();
            var vm = new PieVM
            {
                Pie = pie,
                Name = pie.Name,
                Price = pie.Price,
                ShortDesc = pie.ShortDesc,
                CategoryId = pie.CategoryId
            };
            return View(vm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id, Name,Price,ShortDesc,CategoryId")] Pie pie)
        {
            if (id != pie.Id) return NotFound();
            if (ModelState.IsValid)
            {
                _pieRepo.UpdatePie(pie);
                _pieRepo.SaveChanges();
                return RedirectToAction("PieList", new { categoryId = pie.CategoryId });
            }
            return View(pie);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var pie = _pieRepo.GetPieById(id);
            if (pie == null) return NotFound();
            return View(pie);
        }

        // POST: Categories1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var pie = _pieRepo.GetPieById(id);
            _pieRepo.DeletePie(pie);
            _pieRepo.SaveChanges();
            return RedirectToAction("PieList", new { categoryId = pie.CategoryId });
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();
            var pie = _pieRepo.GetPieById(id);
            if (pie == null) return NotFound();
            return View(pie);
        }
    }

}
