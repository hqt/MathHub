using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using MathHub.Core.Config;
using MathHub.Core.Interfaces.Blogs;
using MathHub.Core.Interfaces.Problems;
using MathHub.Core.Interfaces.Users;
using MathHub.Entity.Entity;
using MathHub.Web.Models.CommonVM;
using WebMatrix.WebData;

namespace MathHub.Web.Controllers
{
    [ChildActionOnly]
    public class CommonWidgetController : Controller
    {
        private IUserQueryService _userQueryService;
        private IBlogQueryService _blogQueryService;
        private IProblemQueryService _problemQueryService;

        public CommonWidgetController(IUserQueryService userQueryService
                                      , IBlogQueryService blogQueryService
                                      , IProblemQueryService problemQueryService)
        {
            _userQueryService = userQueryService;
            _blogQueryService = blogQueryService;
            _problemQueryService = problemQueryService;
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
            ICollection<Tag> tags = _userQueryService.getLoginUserFavoriteTag().ToList();
            return PartialView("_FavoriteTagWidget", tags);
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
            ICollection<Blog> blogs = _blogQueryService.GetNewBlogs(Constant.DEFAULT_PER_WIDGET).ToList();
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
            User user = _userQueryService.GetLoginUser();
            ProfileWidgetVM profileWidgetVm = Mapper.Map<User, ProfileWidgetVM>(user);

            return PartialView("_ProfileWidget", profileWidgetVm);
        }

        public ActionResult RelatedBlogWidget()
        {
            return PartialView("_RelatedBlogWidget");
        }

        public ActionResult RelatedTagWidget()
        {
            return PartialView("_RelatedTagWidget");
        }

        public ActionResult SameAuthorWidget(int id)
        {
            ICollection<Problem> problems = _problemQueryService.GetProblemsByUserId(id, Constant.DEFAULT_PER_WIDGET).ToList();
            return PartialView("_SameAuthorWidget", problems);
        }

        public ActionResult SubscriptionWidget()
        {
            ICollection<Subscription> subscriptions = _userQueryService.GetLoginUserSubcriptions().ToList();
            return PartialView("_SubscriptionWidget", subscriptions);
        }

        public ActionResult YourActivityWidget()
        {
            return PartialView("_YourActivityWidget");
        }


    }
}
