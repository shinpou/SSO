﻿using System.Web.Mvc;

namespace Client2.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        [Route("about")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}