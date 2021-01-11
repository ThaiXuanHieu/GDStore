using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GDStore.MVC.Services;
using GDStore.ViewModel.Users;
using Microsoft.AspNetCore.Mvc;

namespace GDStore.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IUserApiClient _userApiClient;

        public UserController(IUserApiClient userApiClient)
        {
            _userApiClient = userApiClient;
        }
        public async Task<IActionResult> List()
        {
            var users = await _userApiClient.GetAll();
            return View(users);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm] RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var result = await _userApiClient.Register(request);
            if (result.IsSuccessed)
            {
                TempData["message"] = "Thêm sản phẩm thành công";
                return RedirectToAction("List");
            }

            return View(request);
        }
    }
}
