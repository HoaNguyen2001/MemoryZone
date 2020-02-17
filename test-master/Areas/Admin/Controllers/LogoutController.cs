using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace project_news.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LogoutController : Controller
    {
        public IActionResult Index()
        {
            //huy session email
            HttpContext.Session.Remove("email");
            //di chuyen den url /Login
            return Redirect("/Login");
        }
    }
}