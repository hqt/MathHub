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
            return View();
        }

        public ActionResult ProfileWidget()
        {
            return View();
        }

        public ActionResult FavoriteTagWidget()
        {
            return View();
        }

        public ActionResult GroupWidget()
        {
            return View();
        }

        public ActionResult SubscriptionWidget()
        {
            return View();
        }

        public ActionResult CreateProblemWidget()
        {
            return View();
        }

        public ActionResult MySubscriptionBlogsWidget()
        {
            return View();
        }

        public ActionResult NewBlogsWidget()
        {
            return View();
        }

        public ActionResult FooterWidget()
        {
            return View();
        }

        public ActionResult ProblemPostGuide()
        {
            return View();
        }
    }
}
