using System;
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

        [HandleError(Master="",ExceptionType=typeof(ArgumentException),View="Error.Argument")]
        public ActionResult Oops(string type="")
        {
            if (type == "1")
            {
                throw new ArgumentException("參數錯誤發生!!");
            }
            else
            {
                throw new Exception("自訂錯誤發生!!");
            }
            
        }
    }
}