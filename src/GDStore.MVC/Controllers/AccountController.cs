using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GDStore.MVC.Services;
using GDStore.ViewModel.Users;
using Microsoft.AspNetCore.Mvc;

namespace GDStore.MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserApiClient _userApiClient;
        public AccountController(IUserApiClient userApiClient)
        {
            _userApiClient = userApiClient;
        }
        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> LoginHandle([FromForm] LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var result = await _userApiClient.Login(request);
            if (string.IsNullOrEmpty(result.ResultObj))
            {
                ModelState.AddModelError("Error", "Đăng nhập thất bại");
                return View("Login");
            }

            return Redirect("/Admin/Home/Index");
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
