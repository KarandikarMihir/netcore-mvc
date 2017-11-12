using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using netcore_mvc.Models;

namespace netcore_mvc.Controllers {
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            if (!String.IsNullOrWhiteSpace(HttpContext.Session.GetString("user"))) {
                return Redirect("/");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid) {
                HttpContext.Session.SetString("user", model.Email);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}