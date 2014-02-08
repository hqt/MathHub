using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MathHub.Web.Controllers
{
    [ChildActionOnly]
    public class CommonWidgetController : Controller
    {
        public ActionResult HeaderWidget()
        {           
            return PartialView();
        }

        public ActionResult ProfileWidget()
        {
            return PartialView();
        }

        public ActionResult FavoriteTagWidget()
        {
            return PartialView();
        }

        public ActionResult GroupWidget()
        {
            return PartialView();
        }

        public ActionResult SubscriptionWidget()
        {
            return PartialView();
        }

        public ActionResult CreateProblemWidget()
        {
            return PartialView();
        }

        public ActionResult MySubscriptionBlogsWidget()
        {
            return PartialView();
        }

        public ActionResult NewBlogsWidget()
        {
            return PartialView();
        }

        public ActionResult FooterWidget()
        {
            return PartialView();
        }

        public ActionResult ProblemPostGuide()
        {
            return PartialView();
        }
    }
}
