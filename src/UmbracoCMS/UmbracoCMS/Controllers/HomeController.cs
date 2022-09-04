using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UmbracoCMS.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/Error
        public ActionResult Error()
        {
            return View();
        }
    }
}