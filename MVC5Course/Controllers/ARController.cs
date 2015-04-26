using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class ARController : BaseController
    {
        // GET: AR
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult File1()
        {
            WebClient wc = new WebClient();
            byte[] content = wc.DownloadData("http://www.imageshop.com.tw/pic/shop/home/men-world.jpg");
            return File(content, "image/jpeg");
        }
        public ActionResult File2()
        {
            byte[] content = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/1.jpg"));
            return File(content, "image/jpeg");
        }
        public ActionResult File3()
        {
            WebClient wc = new WebClient();
            byte[] content = wc.DownloadData("http://www.imageshop.com.tw/pic/shop/home/men-world.jpg");
            return File(content, "image/jpeg", "man.jpg");
        }
        public ActionResult File4()
        {
            
            //return File(Server.MapPath("~/Content/test.html"),"text/plain");
            return File(Server.MapPath("~/Content/test.html"), "text/html");
        }

        public ActionResult JSON()
        {
            //防止序列化錯誤
            //db.Configuration.LazyLoadingEnabled = false;
            //var product = db.Product.Take(10);

            repoProduct.UnitOfWork.LazyLoadingEnabled = false;
            var repo = repoProduct.All().Take(10);

            return Json(repo, JsonRequestBehavior.AllowGet);
        }

    }
}