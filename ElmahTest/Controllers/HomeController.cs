﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Elmah.BAL;

namespace ElmahTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(DateTime? sdata, DateTime? edata)
        {

            MYBal x = new MYBal();
            x.Test();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}