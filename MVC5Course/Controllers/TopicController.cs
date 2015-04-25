using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class TopicController : BaseController
    {
        // GET: Topic
        public ActionResult Index()
        {
            return View();
        }
    }
}