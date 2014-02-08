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
            return PartialView("_HeaderWidget");
        }

        public ActionResult FooterWidget()
        {
            return PartialView("_FooterWidget");
        }

        public ActionResult FavoriteTagWidget()
        {
            return PartialView("_FavoriteTagWidget");
        }

        public ActionResult GroupWidget()
        {
            return PartialView("_GroupWidget");
        }

        public ActionResult MySubscriptionWidget()
        {
            return PartialView("_MySubscriptionWidget");
        }

        public ActionResult NewBlogWidget()
        {
            return PartialView("_NewBlogWidget");
        }

        public ActionResult PostProblemWidget()
        {
            return PartialView("_PostProblemWidget");
        }

        public ActionResult ProblemPostGuide()
        {
            return PartialView("_ProblemPostGuide");
        }

        public ActionResult ProfileWidget()
        {
            return PartialView("_ProfileWidget");
        }

        public ActionResult RelatedBlogWidget()
        {
            return PartialView("_RelatedBlogWidget");
        }

        public ActionResult RelatedTagWidget()
        {
            return PartialView("_RelatedTagWidget");
        }

        public ActionResult SameAuthorWidget()
        {
            return PartialView("_SameAuthorWidget");
        }

        public ActionResult SubscriptionWidget()
        {
            return PartialView("_SubscriptionWidget");
        }

        public  ActionResult YourActivityWidget()
        {
            return PartialView("_YourActivityWidget");
        }

        
    }
}
