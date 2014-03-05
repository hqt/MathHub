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

namespace MathHub.Web.Controllers
{
    [ChildActionOnly]
    public partial class CommonWidgetController : Controller
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

        public virtual ActionResult HeaderWidget()
        {
            return PartialView("_HeaderWidget");
        }

        public virtual ActionResult FooterWidget()
        {
            return PartialView("_FooterWidget");
        }

        public virtual ActionResult FavoriteTagWidget()
        {
            ICollection<Tag> tags = _userQueryService.getLoginUserFavoriteTag().ToList();
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

        public virtual ActionResult NewBlogWidget()
        {
            ICollection<Blog> blogs = _blogQueryService.GetNewBlogs(Constant.DEFAULT_PER_WIDGET).ToList();
            return PartialView("_NewBlogWidget", blogs);
        }

        public virtual ActionResult PostProblemWidget()
        {
            return PartialView("_PostProblemWidget");
        }

        public virtual ActionResult ProblemPostGuide()
        {
            return PartialView("_ProblemPostGuide");
        }

        public virtual ActionResult ProfileWidget()
        {

            //// Profile
            //Mapper.CreateMap<User, ProfileWidgetVM>()
            //    .ForMember(p => p.Medal,
            //        m => m.MapFrom(
            //        s => ((IUserQueryService)null).GetMedals(s.Id)
            //    ))
            //    .ForMember(p => p.Avatar,
            //        m => m.MapFrom(
            //        s => ((IUserQueryService)null).GetLoginUserAvatar()
            //    ));

            User user = _userQueryService.GetLoginUser();
            ProfileWidgetVM profileWidgetVm = Mapper.Map<User, ProfileWidgetVM>(user);

            return PartialView("_ProfileWidget", profileWidgetVm);
        }

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

        public virtual ActionResult SubscriptionWidget()
        {
            ICollection<Subscription> subscriptions = _userQueryService.GetLoginUserSubcriptions().ToList();
            return PartialView("_SubscriptionWidget", subscriptions);
        }

        public virtual ActionResult YourActivityWidget()
        {
            return PartialView("_YourActivityWidget");
        }


    }
}
