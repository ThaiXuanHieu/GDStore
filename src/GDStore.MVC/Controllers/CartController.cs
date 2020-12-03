using Microsoft.AspNetCore.Mvc;

namespace GDStore.MVC.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
