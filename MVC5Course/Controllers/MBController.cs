using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class MBController : BaseController
    {
        // GET: MB
        public ActionResult Index()
        {
            ViewData.Model = db.Client.Find(3);

            ViewData["product"] = db.Product.Find(100);
            return View();
        }
        public ActionResult DataTrans()
        {
            ViewData["MSG1"] = "MSG IN ViewData";
            TempData["MSG2"] = "MSG IN TempData";
            Session["MSG3"] = "MSG IN Session";

            return RedirectToAction("DataTransResult");
        }
        public ActionResult DataTransResult()
        {
            ViewBag.MSG1 = ViewData["MSG1"];
            ViewBag.MSG2 = TempData["MSG2"];
            ViewBag.MSG3 = Session["MSG3"];
            return View();
        }
    }
}