using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using netcore_mvc.Models;

namespace netcore_mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (!String.IsNullOrWhiteSpace(HttpContext.Session.GetString("user")))
            {
                return View();
            }
            return Redirect("Login");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
