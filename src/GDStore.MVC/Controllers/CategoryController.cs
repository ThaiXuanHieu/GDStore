using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GDStore.MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace GDStore.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryApiClient _categoryApiClient;
        public CategoryController(ICategoryApiClient categoryApiClient)
        {
            _categoryApiClient = categoryApiClient;
        }
        public async Task<IActionResult> List()
        {
            var data = await _categoryApiClient.GetAll();
            return View(data);
        }
    }
}
