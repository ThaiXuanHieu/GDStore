using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GDStore.MVC.Services;
using GDStore.ViewModel.Products;
using Microsoft.AspNetCore.Mvc;

namespace GDStore.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        public ProductController(IProductApiClient productApiClient)
        {
            _productApiClient = productApiClient;
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Add([FromForm] ProductCreateRequest request)
        {
            if(!ModelState.IsValid)
            {
                return View(request);
            }

            try
            {
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
