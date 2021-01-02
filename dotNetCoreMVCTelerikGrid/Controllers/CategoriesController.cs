using dotNetCoreMVCTelerikGrid.Services.Abstraction;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetCoreMVCTelerikGrid.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryRepo _categoryRepo;
        public CategoriesController(ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult TelerikUITest()
        {
            return View();
        }
        public ActionResult Categories_Read([DataSourceRequest] DataSourceRequest request)
        {
            var result = _categoryRepo.GetAllCategories;
            var dsResult = result.ToDataSourceResult(request);
            return Json(dsResult);
        }
    }
   
}
