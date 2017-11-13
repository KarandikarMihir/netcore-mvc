using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

public class LogoutController : Controller
{
    public IActionResult Index()
    {
        HttpContext.Session.Clear();
        return Redirect("/");
    }
}