using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GDStore.MVC.Services;
using GDStore.ViewModel.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GDStore.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;
        public ProductController(IProductApiClient productApiClient, ICategoryApiClient categoryApiClient)
        {
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
        }
        public async Task<IActionResult> List()
        {
            var categories = await _categoryApiClient.GetAll();
            ViewBag.Categories = categories.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> AddHandle([FromForm] ProductCreateRequest request, List<IFormFile> files)
        {
            if (files == null || files.Count == 0)
            {
                TempData["message"] = "Ảnh chưa được chọn";
                return View("Add");
            }
            if (!ModelState.IsValid)
            {
                return View("Add", request);
            }

            try
            {
                request.ThumbnailImage = files;
                await _productApiClient.Add(request);
                TempData["message"] = "Thêm sản phẩm thành công";
                return RedirectToAction("List");
            }
            catch (Exception)
            {
                return View(request);
            }

        }
    }
}
