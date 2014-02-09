using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MathHub.Core.Interfaces.Blogs;
using MathHub.Core.Interfaces.Users;
using MathHub.Entity.Entity;
using WebMatrix.WebData;

namespace MathHub.Web.Controllers
{
    [ChildActionOnly]
    public class CommonWidgetController : Controller
    {
        private IUserQueryService _userQueryService;
        private IBlogQueryService _blogQueryService;
        public CommonWidgetController(IUserQueryService userQueryService
                                      , IBlogQueryService blogQueryService)
        {
            _userQueryService = userQueryService;
            _blogQueryService = blogQueryService;
        }

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
            ICollection<Tag> tags = null;//_userQueryService.getLoginUserFavoriteTag().ToList();
            return PartialView("_FavoriteTagWidget", tags);
        }

        public ActionResult GroupWidget()
        {
            return PartialView("_GroupWidget");
        }

        public ActionResult MySubscriptionWidget()
        {
            ICollection<Subscription> subscriptions = null;
            return PartialView("_MySubscriptionWidget", subscriptions);
        }

        public ActionResult NewBlogWidget()
        {
            ICollection<Blog> blogs = null;
            return PartialView("_NewBlogWidget", blogs);
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
            //User user = _userQueryService.GetCurrentLoginUser();

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

        public ActionResult YourActivityWidget()
        {
            return PartialView("_YourActivityWidget");
        }


    }
}
