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
using StructureMap;
using MathHub.Framework.Controllers;

namespace MathHub.Web.Controllers
{
    [ChildActionOnly]
    public partial class CommonWidgetController : BaseController
    {

        #region Constructor
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
        #endregion

        #region Blog Widget
        public virtual ActionResult NewBlogWidget()
        {
            ICollection<Blog> blogs = _blogQueryService.GetNewBlogs(Constant.DEFAULT_PER_WIDGET).ToList();
            return PartialView("_NewBlogWidget", blogs);
        }

        public virtual ActionResult PostBlogWidget()
        {
            return PartialView("_PostBlogWidget");
        }

        public virtual ActionResult BlogPostGuide()
        {
            return PartialView("_BlogPostGuide");
        }
        #endregion

        #region Problem Widget
        public virtual ActionResult PostProblemWidget()
        {
            return PartialView("_PostProblemWidget");
        }

        public virtual ActionResult ProblemPostGuide()
        {
            return PartialView("_ProblemPostGuide");
        } 
        #endregion

        #region Discussion Widget
        public virtual ActionResult PostDiscussionWidget()
        {
            return PartialView("_PostDiscussionWidget");
        }

        public virtual ActionResult DiscussionPostGuide()
        {
            return PartialView("_DiscussionPostGuide");
        } 
        #endregion

        #region User Widget
        public virtual ActionResult ProfileWidget()
        {

            User user = _userQueryService.GetLoginUser();
            ProfileWidgetVM profileWidgetVm = Mapper.Map<User, ProfileWidgetVM>(user);

            return PartialView("_ProfileWidget", profileWidgetVm);
        }

        public virtual ActionResult FavoriteTagWidget()
        {
            ICollection<Tag> tags = _userQueryService.GetLoginFavoriteTag().ToList();
            return PartialView("_FavoriteTagWidget", tags);
        }

        public virtual ActionResult GroupWidget()
        {
            return PartialView("_GroupWidget");
        }

        public virtual ActionResult MySubscriptionWidget()
        {

            return PartialView("_MySubscriptionWidget");
        }

        public virtual ActionResult SubscriptionWidget()
        {
            ICollection<Subscription> subscriptions = _userQueryService.GetLoginAllSubscriptions().ToList();
            return PartialView("_SubscriptionWidget", subscriptions);
        }

        public virtual ActionResult YourActivityWidget()
        {
            return PartialView("_YourActivityWidget");
        }
        #endregion

        #region Common Widget
        public virtual ActionResult RelatedBlogWidget()
        {
            return PartialView("_RelatedBlogWidget");
        }

        public virtual ActionResult RelatedTagWidget()
        {
            return PartialView("_RelatedTagWidget");
        }

        public virtual ActionResult SameAuthorWidget(int id)
        {
            ICollection<Problem> problems = _problemQueryService.GetProblemsByUserId(id, Constant.DEFAULT_PER_WIDGET).ToList();
            return PartialView("_SameAuthorWidget", problems);
        }

        public virtual ActionResult HeaderWidget()
        {
            return PartialView("_HeaderWidget");
        }

        public virtual ActionResult FooterWidget()
        {
            return PartialView("_FooterWidget");
        } 
        #endregion

    }
}
