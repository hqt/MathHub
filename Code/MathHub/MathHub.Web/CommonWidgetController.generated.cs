// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace MathHub.Web.Controllers
{
    public partial class CommonWidgetController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected CommonWidgetController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult SameAuthorWidget()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SameAuthorWidget);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public CommonWidgetController Actions { get { return MVC.CommonWidget; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "CommonWidget";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "CommonWidget";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string NewBlogWidget = "NewBlogWidget";
            public readonly string PostBlogWidget = "PostBlogWidget";
            public readonly string BlogPostGuide = "BlogPostGuide";
            public readonly string PostProblemWidget = "PostProblemWidget";
            public readonly string ProblemPostGuide = "ProblemPostGuide";
            public readonly string PostDiscussionWidget = "PostDiscussionWidget";
            public readonly string DiscussionPostGuide = "DiscussionPostGuide";
            public readonly string ProfileWidget = "ProfileWidget";
            public readonly string FavoriteTagWidget = "FavoriteTagWidget";
            public readonly string GroupWidget = "GroupWidget";
            public readonly string MySubscriptionWidget = "MySubscriptionWidget";
            public readonly string SubscriptionWidget = "SubscriptionWidget";
            public readonly string YourActivityWidget = "YourActivityWidget";
            public readonly string RelatedBlogWidget = "RelatedBlogWidget";
            public readonly string RelatedTagWidget = "RelatedTagWidget";
            public readonly string SameAuthorWidget = "SameAuthorWidget";
            public readonly string HeaderWidget = "HeaderWidget";
            public readonly string FooterWidget = "FooterWidget";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string NewBlogWidget = "NewBlogWidget";
            public const string PostBlogWidget = "PostBlogWidget";
            public const string BlogPostGuide = "BlogPostGuide";
            public const string PostProblemWidget = "PostProblemWidget";
            public const string ProblemPostGuide = "ProblemPostGuide";
            public const string PostDiscussionWidget = "PostDiscussionWidget";
            public const string DiscussionPostGuide = "DiscussionPostGuide";
            public const string ProfileWidget = "ProfileWidget";
            public const string FavoriteTagWidget = "FavoriteTagWidget";
            public const string GroupWidget = "GroupWidget";
            public const string MySubscriptionWidget = "MySubscriptionWidget";
            public const string SubscriptionWidget = "SubscriptionWidget";
            public const string YourActivityWidget = "YourActivityWidget";
            public const string RelatedBlogWidget = "RelatedBlogWidget";
            public const string RelatedTagWidget = "RelatedTagWidget";
            public const string SameAuthorWidget = "SameAuthorWidget";
            public const string HeaderWidget = "HeaderWidget";
            public const string FooterWidget = "FooterWidget";
        }


        static readonly ActionParamsClass_SameAuthorWidget s_params_SameAuthorWidget = new ActionParamsClass_SameAuthorWidget();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SameAuthorWidget SameAuthorWidgetParams { get { return s_params_SameAuthorWidget; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SameAuthorWidget
        {
            public readonly string id = "id";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _FavoriteTagWidget = "_FavoriteTagWidget";
                public readonly string _FooterWidget = "_FooterWidget";
                public readonly string _GroupWidget = "_GroupWidget";
                public readonly string _HeaderWidget = "_HeaderWidget";
                public readonly string _MySubscriptionWidget = "_MySubscriptionWidget";
                public readonly string _NewBlogWidget = "_NewBlogWidget";
                public readonly string _NewDiscussionWidget = "_NewDiscussionWidget";
                public readonly string _PostDiscussionWidget = "_PostDiscussionWidget";
                public readonly string _PostProblemWidget = "_PostProblemWidget";
                public readonly string _ProblemPostGuide = "_ProblemPostGuide";
                public readonly string _ProfileWidget = "_ProfileWidget";
                public readonly string _RelatedBlogWidget = "_RelatedBlogWidget";
                public readonly string _RelatedTagWidget = "_RelatedTagWidget";
                public readonly string _SameAuthorWidget = "_SameAuthorWidget";
                public readonly string _SubscriptionWidget = "_SubscriptionWidget";
                public readonly string _YourActivityWidget = "_YourActivityWidget";
            }
            public readonly string _FavoriteTagWidget = "~/Views/CommonWidget/_FavoriteTagWidget.cshtml";
            public readonly string _FooterWidget = "~/Views/CommonWidget/_FooterWidget.cshtml";
            public readonly string _GroupWidget = "~/Views/CommonWidget/_GroupWidget.cshtml";
            public readonly string _HeaderWidget = "~/Views/CommonWidget/_HeaderWidget.cshtml";
            public readonly string _MySubscriptionWidget = "~/Views/CommonWidget/_MySubscriptionWidget.cshtml";
            public readonly string _NewBlogWidget = "~/Views/CommonWidget/_NewBlogWidget.cshtml";
            public readonly string _NewDiscussionWidget = "~/Views/CommonWidget/_NewDiscussionWidget.cshtml";
            public readonly string _PostDiscussionWidget = "~/Views/CommonWidget/_PostDiscussionWidget.cshtml";
            public readonly string _PostProblemWidget = "~/Views/CommonWidget/_PostProblemWidget.cshtml";
            public readonly string _ProblemPostGuide = "~/Views/CommonWidget/_ProblemPostGuide.cshtml";
            public readonly string _ProfileWidget = "~/Views/CommonWidget/_ProfileWidget.cshtml";
            public readonly string _RelatedBlogWidget = "~/Views/CommonWidget/_RelatedBlogWidget.cshtml";
            public readonly string _RelatedTagWidget = "~/Views/CommonWidget/_RelatedTagWidget.cshtml";
            public readonly string _SameAuthorWidget = "~/Views/CommonWidget/_SameAuthorWidget.cshtml";
            public readonly string _SubscriptionWidget = "~/Views/CommonWidget/_SubscriptionWidget.cshtml";
            public readonly string _YourActivityWidget = "~/Views/CommonWidget/_YourActivityWidget.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_CommonWidgetController : MathHub.Web.Controllers.CommonWidgetController
    {
        public T4MVC_CommonWidgetController() : base(Dummy.Instance) { }

        [NonAction]
        partial void NewBlogWidgetOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult NewBlogWidget()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.NewBlogWidget);
            NewBlogWidgetOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void PostBlogWidgetOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult PostBlogWidget()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PostBlogWidget);
            PostBlogWidgetOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void BlogPostGuideOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult BlogPostGuide()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.BlogPostGuide);
            BlogPostGuideOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void PostProblemWidgetOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult PostProblemWidget()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PostProblemWidget);
            PostProblemWidgetOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ProblemPostGuideOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult ProblemPostGuide()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ProblemPostGuide);
            ProblemPostGuideOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void PostDiscussionWidgetOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult PostDiscussionWidget()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PostDiscussionWidget);
            PostDiscussionWidgetOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void DiscussionPostGuideOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult DiscussionPostGuide()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DiscussionPostGuide);
            DiscussionPostGuideOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ProfileWidgetOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult ProfileWidget()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ProfileWidget);
            ProfileWidgetOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void FavoriteTagWidgetOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult FavoriteTagWidget()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.FavoriteTagWidget);
            FavoriteTagWidgetOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void GroupWidgetOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult GroupWidget()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GroupWidget);
            GroupWidgetOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void MySubscriptionWidgetOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult MySubscriptionWidget()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.MySubscriptionWidget);
            MySubscriptionWidgetOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void SubscriptionWidgetOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult SubscriptionWidget()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SubscriptionWidget);
            SubscriptionWidgetOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void YourActivityWidgetOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult YourActivityWidget()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.YourActivityWidget);
            YourActivityWidgetOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void RelatedBlogWidgetOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult RelatedBlogWidget()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RelatedBlogWidget);
            RelatedBlogWidgetOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void RelatedTagWidgetOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult RelatedTagWidget()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RelatedTagWidget);
            RelatedTagWidgetOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void SameAuthorWidgetOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

        [NonAction]
        public override System.Web.Mvc.ActionResult SameAuthorWidget(int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SameAuthorWidget);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            SameAuthorWidgetOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void HeaderWidgetOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult HeaderWidget()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.HeaderWidget);
            HeaderWidgetOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void FooterWidgetOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult FooterWidget()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.FooterWidget);
            FooterWidgetOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
