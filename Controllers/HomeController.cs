using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using netcore_mvc.Models;
using Microsoft.AspNetCore.Authorization;
using netcore_mvc.Filters;
using netcore_mvc.SQL;

namespace netcore_mvc.Controllers
{
    public class HomeController : Controller
    {
        [AuthFilter]
        public IActionResult Index()
        {
            SqlUtility util = new SqlUtility();
            List<UserModel> Users = new List<UserModel>();
            util.Connect();
            Users = util.GetUsers();
            util.Disconnect();
            ViewData["users"] = Users.ToList();
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
