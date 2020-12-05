using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GDStore.MVC.Models;
using GDStore.MVC.Services;
using Microsoft.Extensions.Configuration;
using GDStore.Application.Common;
using System.Threading.Tasks;

namespace GDStore.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductApiClient _productApiClient;
        private readonly IConfiguration _config;
        public HomeController(ILogger<HomeController> logger, IProductApiClient productApiClient, IConfiguration config)
        {
            _logger = logger;
            _productApiClient = productApiClient;
            _config = config;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["BackendUrl"] = _config[Constants.AppSettings.BaseAddress];
            var products = await _productApiClient.GetAll();
            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
