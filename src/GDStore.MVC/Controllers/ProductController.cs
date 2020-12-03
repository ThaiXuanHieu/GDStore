using GDStore.MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace GDStore.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;
        public ProductController(IProductApiClient productApiClient, ICategoryApiClient categoryApiClient)
        {
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
        }

        public IActionResult Detail()
        {
            return View();
        }
        
    }
}
