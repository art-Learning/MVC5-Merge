using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class ExtraInfoController : BaseController
    {
        // GET: ExtraInfo
        public ActionResult Index()
        {
            return View();
            //TODO 補充資訊第六天的VIEW ( /Views/ExtraInfo/ExtraInfoDay6.cshtml)不見了，要找時間補上
        }
    }
}