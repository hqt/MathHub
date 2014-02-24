using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MathHub.Core.Interfaces.Comments;
using MathHub.Core.Interfaces.Problems;
using MathHub.Entity.Entity;
using MathHub.Framework.Controllers;
using AutoMapper;
using MathHub.Web.Models.ProblemVM;
using MathHub.Core.Config;
using MathHub.Web.CustomAnnotation.ActionFilter;
using WebMatrix.WebData;

namespace MathHub.Web.Controllers
{
    public partial class ProblemController : BaseController
    {

        private IProblemQueryService _problemQueryService;
        private IProblemCommandService _problemCommandService;
        private ICommentCommandService _commentCommandService;

        public ProblemController(
            IProblemQueryService problemQueryService,
            ICommentCommandService commentCommandService,
            IProblemCommandService problemCommandService)
        {
            _problemQueryService = problemQueryService;
            _commentCommandService = commentCommandService;
            _problemCommandService = problemCommandService;
        }

        // GET /Problem
        public virtual ActionResult Index()
        {
            return RedirectToAction(MathHub.Core.Config.RouteDefaults.DEFAULT_PROBLEM_TAB);
        }

        // GET /Problem/Trending
        public virtual ActionResult Trending()
        {
            return View("Views/ListAllProblem");
        }

        // GET /Problem/Mytags
        public virtual ActionResult Mytags()
        {
            return View("Views/ListAllProblem");
        }

        // GET /Problem/Unanswered
        public virtual ActionResult Unanswered()
        {
            return View("Views/ListAllProblem");
        }

        // GET /Problem/Newest
        public virtual ActionResult Newest()
        {
            IEnumerable<Problem> problems =
                _problemQueryService.GetNewestProblems(
                Constant.DEFAULT_OFFSET, Constant.DEFAULT_PER_PAGE);

            ICollection<PreviewProblemVM> problemVms =
                problems.Select(Mapper.Map<Problem, PreviewProblemVM>).ToList();

            return View("Views/ListAllProblem", problemVms);
        }


        [Authorize]
        // GET /Problem/Create
        public virtual ActionResult Create()
        {
            return View("Views/CreateProblem");
        }

        // POST /Problem/Create
        [Authorize]
        [HttpPost]
        public virtual ActionResult Create(int userId, string title, string content, List<string> tags)
        {
            Problem p = new Problem();
            p.UserId = userId;
            p.Title = title;
            p.Content = content;

            bool res = _problemCommandService.AddProblem(p);
            if (!res)
            {
                return null;
            }
            else
            {
                return Detail(p.Id);
            }
        }

        // GET /Problem/Detail/1
        public virtual ActionResult Detail(int? id)
        {
            // ViewBag.Problem = _rproblemService.GetProblemById(id);
            if (!id.HasValue)
            {
                return RedirectToAction("Index");
            }
            Problem targetProblem = _problemQueryService.GetProblemById((int)id);

            // Map from Model to ViewModel
            DetailProblemVM problemViewModel =
                Mapper.Map<Problem, DetailProblemVM>(targetProblem);
            problemViewModel.CommentPostVm = new CommentPostVM();
            problemViewModel.CommentPostVm.MainPostId = problemViewModel.Id;
            problemViewModel.CommentPostVm.Type = "problem";

            return View("Views/DetailProblem", problemViewModel);
        }

        [AjaxCallAF]
        public virtual ActionResult Answer(int id, int offset)
        {
            IEnumerable<Reply> answers = _problemQueryService.GetAllReplies(
                    id,
                    ReplyEnum.ANSWER,
                    offset,
                    Constant.DEFAULT_PER_PAGE
                ).AsEnumerable();

            ICollection<AnswerItemVM> answerItemVms = answers.Select(Mapper.Map<Reply, AnswerItemVM>).ToList();
            AnswerListVM answerListVm = new AnswerListVM();
            answerListVm.AnswerItemVms = answerItemVms;
            return PartialView("Partials/_AnswerList", answerListVm);
        }

        [AjaxCallAF]
        public virtual ActionResult Hint(int postId, int offset)
        {
            IEnumerable<Reply> hints = _problemQueryService.GetAllReplies(
                    postId,
                    ReplyEnum.HINT,
                    offset,
                    Constant.DEFAULT_PER_PAGE
                ).AsEnumerable();

            // Map list models to list viewmodels with lambda expression 
            ICollection<HintItemVM> hintItemVms = hints.Select(Mapper.Map<Reply, HintItemVM>).ToList();
            HintListVM hintListVm = new HintListVM();
            hintListVm.HintItemVms = hintItemVms;
            return PartialView("Partials/_HintList", hintListVm);
        }

        [AjaxCallAF]
        public virtual ActionResult Comment(int postId, int offset)
        {
            offset = offset < 0 ? Constant.DEFAULT_COMMENT_OFFSET : offset;
            int limit = offset < 0 ? int.MaxValue : Constant.DEFAULT_COMMENT_LOADING;

            IEnumerable<Comment> comments = _problemQueryService.GetAllComments(
                postId,
                offset,
                limit
                );

            // Map list models to list viewmodels with lambda expression 
            ICollection<CommentItemVM> hintItemVms = comments.Select(Mapper.Map<Comment, CommentItemVM>).ToList();

            CommentListVM commentListVm = new CommentListVM();

            commentListVm.CommentItemVms = hintItemVms;
            return PartialView("Partials/_CommentList", commentListVm);
        }

        
        [Authorize]
        public bool AddComment(CommentPostVM commentPostVm)
        {
            if (ModelState.IsValid)
            {
                Comment comment = new Comment();
                comment.UserId = WebSecurity.CurrentUserId;
                comment.DateCreated = DateTime.Now;
                comment.Content = commentPostVm.Content;

                switch (commentPostVm.Type)
                {
                    case "problem":
                        //comment.MainPostId = commentPostVm.MainPostId;
                        return _commentCommandService.AddCommentForPost((int)commentPostVm.MainPostId, comment);

                    case "Reply":
                        //comment.ReplyId = commentPostVm.ReplyId;
                        return _commentCommandService.AddCommentForReply((int)comment.ReplyId, comment);

                    default:
                        return false;
                }

            }
            return false;
        }
    }
}
