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
    public partial class ProblemController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected ProblemController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult Detail()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Detail);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Answer()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Answer);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Hint()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Hint);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult GetReplyComments()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetReplyComments);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult GetQuestionComments()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetQuestionComments);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult AddComment()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddComment);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult AddAnswer()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddAnswer);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult AddHint()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddHint);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ProblemController Actions { get { return MVC.Problem; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Problem";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Problem";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Trending = "Trending";
            public readonly string Mytags = "Mytags";
            public readonly string Unanswered = "Unanswered";
            public readonly string Newest = "Newest";
            public readonly string Create = "Create";
            public readonly string Detail = "Detail";
            public readonly string Answer = "Answer";
            public readonly string Hint = "Hint";
            public readonly string GetReplyComments = "GetReplyComments";
            public readonly string GetQuestionComments = "GetQuestionComments";
            public readonly string AddComment = "AddComment";
            public readonly string AddAnswer = "AddAnswer";
            public readonly string AddHint = "AddHint";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Trending = "Trending";
            public const string Mytags = "Mytags";
            public const string Unanswered = "Unanswered";
            public const string Newest = "Newest";
            public const string Create = "Create";
            public const string Detail = "Detail";
            public const string Answer = "Answer";
            public const string Hint = "Hint";
            public const string GetReplyComments = "GetReplyComments";
            public const string GetQuestionComments = "GetQuestionComments";
            public const string AddComment = "AddComment";
            public const string AddAnswer = "AddAnswer";
            public const string AddHint = "AddHint";
        }


        static readonly ActionParamsClass_Create s_params_Create = new ActionParamsClass_Create();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Create CreateParams { get { return s_params_Create; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Create
        {
            public readonly string problemVM = "problemVM";
        }
        static readonly ActionParamsClass_Detail s_params_Detail = new ActionParamsClass_Detail();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Detail DetailParams { get { return s_params_Detail; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Detail
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_Answer s_params_Answer = new ActionParamsClass_Answer();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Answer AnswerParams { get { return s_params_Answer; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Answer
        {
            public readonly string postId = "postId";
            public readonly string offset = "offset";
        }
        static readonly ActionParamsClass_Hint s_params_Hint = new ActionParamsClass_Hint();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Hint HintParams { get { return s_params_Hint; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Hint
        {
            public readonly string postId = "postId";
            public readonly string offset = "offset";
        }
        static readonly ActionParamsClass_GetReplyComments s_params_GetReplyComments = new ActionParamsClass_GetReplyComments();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetReplyComments GetReplyCommentsParams { get { return s_params_GetReplyComments; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetReplyComments
        {
            public readonly string postId = "postId";
            public readonly string offset = "offset";
        }
        static readonly ActionParamsClass_GetQuestionComments s_params_GetQuestionComments = new ActionParamsClass_GetQuestionComments();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetQuestionComments GetQuestionCommentsParams { get { return s_params_GetQuestionComments; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetQuestionComments
        {
            public readonly string postId = "postId";
            public readonly string offset = "offset";
        }
        static readonly ActionParamsClass_AddComment s_params_AddComment = new ActionParamsClass_AddComment();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AddComment AddCommentParams { get { return s_params_AddComment; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AddComment
        {
            public readonly string commentPostVm = "commentPostVm";
        }
        static readonly ActionParamsClass_AddAnswer s_params_AddAnswer = new ActionParamsClass_AddAnswer();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AddAnswer AddAnswerParams { get { return s_params_AddAnswer; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AddAnswer
        {
            public readonly string answerPostVm = "answerPostVm";
        }
        static readonly ActionParamsClass_AddHint s_params_AddHint = new ActionParamsClass_AddHint();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AddHint AddHintParams { get { return s_params_AddHint; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AddHint
        {
            public readonly string hintPostVm = "hintPostVm";
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
            }
            static readonly _LayoutsClass s_Layouts = new _LayoutsClass();
            public _LayoutsClass Layouts { get { return s_Layouts; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _LayoutsClass
            {
                static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
                public class _ViewNamesClass
                {
                    public readonly string _ProblemCreateLayout = "_ProblemCreateLayout";
                    public readonly string _ProblemDetailLayout = "_ProblemDetailLayout";
                    public readonly string _ProblemListLayout = "_ProblemListLayout";
                }
                public readonly string _ProblemCreateLayout = "~/Views/Problem/Layouts/_ProblemCreateLayout.cshtml";
                public readonly string _ProblemDetailLayout = "~/Views/Problem/Layouts/_ProblemDetailLayout.cshtml";
                public readonly string _ProblemListLayout = "~/Views/Problem/Layouts/_ProblemListLayout.cshtml";
            }
            static readonly _PartialsClass s_Partials = new _PartialsClass();
            public _PartialsClass Partials { get { return s_Partials; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _PartialsClass
            {
                static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
                public class _ViewNamesClass
                {
                    public readonly string _AnswerItem = "_AnswerItem";
                    public readonly string _AnswerList = "_AnswerList";
                    public readonly string _AnswerPostForm = "_AnswerPostForm";
                    public readonly string _CommentItem = "_CommentItem";
                    public readonly string _CommentList = "_CommentList";
                    public readonly string _CommentPostForm = "_CommentPostForm";
                    public readonly string _HintItem = "_HintItem";
                    public readonly string _HintList = "_HintList";
                    public readonly string _HintPostForm = "_HintPostForm";
                    public readonly string _ProblemItem = "_ProblemItem";
                }
                public readonly string _AnswerItem = "~/Views/Problem/Partials/_AnswerItem.cshtml";
                public readonly string _AnswerList = "~/Views/Problem/Partials/_AnswerList.cshtml";
                public readonly string _AnswerPostForm = "~/Views/Problem/Partials/_AnswerPostForm.cshtml";
                public readonly string _CommentItem = "~/Views/Problem/Partials/_CommentItem.cshtml";
                public readonly string _CommentList = "~/Views/Problem/Partials/_CommentList.cshtml";
                public readonly string _CommentPostForm = "~/Views/Problem/Partials/_CommentPostForm.cshtml";
                public readonly string _HintItem = "~/Views/Problem/Partials/_HintItem.cshtml";
                public readonly string _HintList = "~/Views/Problem/Partials/_HintList.cshtml";
                public readonly string _HintPostForm = "~/Views/Problem/Partials/_HintPostForm.cshtml";
                public readonly string _ProblemItem = "~/Views/Problem/Partials/_ProblemItem.cshtml";
            }
            static readonly _ViewsClass s_Views = new _ViewsClass();
            public _ViewsClass Views { get { return s_Views; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _ViewsClass
            {
                static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
                public class _ViewNamesClass
                {
                    public readonly string CreateProblem = "CreateProblem";
                    public readonly string DetailProblem = "DetailProblem";
                    public readonly string ListAllProblem = "ListAllProblem";
                }
                public readonly string CreateProblem = "~/Views/Problem/Views/CreateProblem.cshtml";
                public readonly string DetailProblem = "~/Views/Problem/Views/DetailProblem.cshtml";
                public readonly string ListAllProblem = "~/Views/Problem/Views/ListAllProblem.cshtml";
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_ProblemController : MathHub.Web.Controllers.ProblemController
    {
        public T4MVC_ProblemController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void TrendingOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Trending()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Trending);
            TrendingOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void MytagsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Mytags()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Mytags);
            MytagsOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void UnansweredOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Unanswered()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Unanswered);
            UnansweredOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void NewestOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Newest()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Newest);
            NewestOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void CreateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Create()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
            CreateOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void CreateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, MathHub.Web.Models.ProblemVM.CreateProblemVM problemVM);

        [NonAction]
        public override System.Web.Mvc.ActionResult Create(MathHub.Web.Models.ProblemVM.CreateProblemVM problemVM)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "problemVM", problemVM);
            CreateOverride(callInfo, problemVM);
            return callInfo;
        }

        [NonAction]
        partial void DetailOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

        [NonAction]
        public override System.Web.Mvc.ActionResult Detail(int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Detail);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            DetailOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void AnswerOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int postId, int offset);

        [NonAction]
        public override System.Web.Mvc.ActionResult Answer(int postId, int offset)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Answer);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "postId", postId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "offset", offset);
            AnswerOverride(callInfo, postId, offset);
            return callInfo;
        }

        [NonAction]
        partial void HintOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int postId, int offset);

        [NonAction]
        public override System.Web.Mvc.ActionResult Hint(int postId, int offset)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Hint);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "postId", postId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "offset", offset);
            HintOverride(callInfo, postId, offset);
            return callInfo;
        }

        [NonAction]
        partial void GetReplyCommentsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int postId, int offset);

        [NonAction]
        public override System.Web.Mvc.ActionResult GetReplyComments(int postId, int offset)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetReplyComments);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "postId", postId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "offset", offset);
            GetReplyCommentsOverride(callInfo, postId, offset);
            return callInfo;
        }

        [NonAction]
        partial void GetQuestionCommentsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int postId, int offset);

        [NonAction]
        public override System.Web.Mvc.ActionResult GetQuestionComments(int postId, int offset)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetQuestionComments);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "postId", postId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "offset", offset);
            GetQuestionCommentsOverride(callInfo, postId, offset);
            return callInfo;
        }

        [NonAction]
        partial void AddCommentOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, MathHub.Web.Models.ProblemVM.CommentPostVM commentPostVm);

        [NonAction]
        public override System.Web.Mvc.ActionResult AddComment(MathHub.Web.Models.ProblemVM.CommentPostVM commentPostVm)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddComment);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "commentPostVm", commentPostVm);
            AddCommentOverride(callInfo, commentPostVm);
            return callInfo;
        }

        [NonAction]
        partial void AddAnswerOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, MathHub.Web.Models.ProblemVM.AnswerPostVM answerPostVm);

        [NonAction]
        public override System.Web.Mvc.ActionResult AddAnswer(MathHub.Web.Models.ProblemVM.AnswerPostVM answerPostVm)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddAnswer);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "answerPostVm", answerPostVm);
            AddAnswerOverride(callInfo, answerPostVm);
            return callInfo;
        }

        [NonAction]
        partial void AddHintOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, MathHub.Web.Models.ProblemVM.HintPostVM hintPostVm);

        [NonAction]
        public override System.Web.Mvc.ActionResult AddHint(MathHub.Web.Models.ProblemVM.HintPostVM hintPostVm)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddHint);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "hintPostVm", hintPostVm);
            AddHintOverride(callInfo, hintPostVm);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
