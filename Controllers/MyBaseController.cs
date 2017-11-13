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
    public class MyBaseController : Attribute
    {
        public MyBaseController(HttpContext context)
        {
            
        }
    }
}
