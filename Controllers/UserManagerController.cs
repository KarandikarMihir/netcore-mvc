using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using netcore_mvc.Models;
using netcore_mvc.Filters;

namespace netcore_mvc.Controllers
{
    public class UserManagerController : Controller
    {
        [AuthFilter]
        public IActionResult Index()
        {
            return View();
        }
    }
}