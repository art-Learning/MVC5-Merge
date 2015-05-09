using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.ActionFliters
{
    public class LoggerAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Trace.TraceInformation("Logger! On Action Executing");
            base.OnActionExecuting(filterContext);
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Trace.TraceInformation("Logger! On Action Executed");
            base.OnActionExecuted(filterContext);
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Trace.TraceInformation("Logger! On Action Executing");
            base.OnResultExecuting(filterContext);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Trace.TraceInformation("Looger! On Result Executed");
            base.OnResultExecuted(filterContext);
        }
    }
}