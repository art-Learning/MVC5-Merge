﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class AFController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Oops()
        {
            throw new Exception("自訂錯誤發生!!");
        }
    }
}