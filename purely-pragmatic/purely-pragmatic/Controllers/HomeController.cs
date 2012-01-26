﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace purely_pragmatic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Purely-Pragmatic.com!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
