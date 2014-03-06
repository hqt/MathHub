using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MathHub.Framework.CustomAnnotation;

namespace MathHub.Web.CustomAnnotation.ActionFilter
{
    public class AjaxCallActionFilter : BaseActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!filterContext.HttpContext.Request.IsAjaxRequest())
                filterContext.HttpContext.Response.Redirect("~/View/Shared/Error.cshtml");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {

        }  
    }
}