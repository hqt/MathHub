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

namespace MathHub.Web.Controllers
{
    public class ProblemController : BaseController
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
        public ActionResult Index()
        {
            return RedirectToAction(MathHub.Core.Config.RouteDefaults.DEFAULT_PROBLEM_TAB);
        }

        // GET /Problem/Trending
        public ActionResult Trending()
        {
            return View("Views/ListAllProblem");
        }

        // GET /Problem/Mytags
        public ActionResult Mytags()
        {
            return View("Views/ListAllProblem");
        }

        // GET /Problem/Unanswered
        public ActionResult Unanswered()
        {
            return View("Views/ListAllProblem");
        }

        // GET /Problem/Newest
        public ActionResult Newest()
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
        public ActionResult Create()
        {
            return View("Views/CreateProblem");
        }

        // POST /Problem/Create
        [Authorize]
        [HttpPost]
        public ActionResult Create(int userId, string title, string content, List<string> tags)
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
        public ActionResult Detail(int? id)
        {
            // ViewBag.Problem = _rproblemService.GetProblemById(id);
            if (!id.HasValue)
            {
                return RedirectToAction("Index");
            }
            Problem targetProblem = _problemQueryService.GetProblemById((int)id);
            targetProblem.Comments = _problemQueryService.GetAllComments(
                targetProblem.Id,
                Constant.DEFAULT_OFFSET,
                Constant.DEFAULT_PER_PAGE).ToList();

            // Map from Model to ViewModel
            DetailProblemVM problemViewModel =
                Mapper.Map<Problem, DetailProblemVM>(targetProblem);


            return View("Views/DetailProblem", problemViewModel);
        }

        [AjaxCallAF]
        public ActionResult Answer(int id, int offset)
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
        public ActionResult Hint(int postId, int offset)
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
        public ActionResult Comment(int postId, int offset)
        {
            IEnumerable<Comment> comments = _problemQueryService.GetAllComments(
                postId,
                offset,
                Constant.DEFAULT_PER_PAGE
                );

           // Map list models to list viewmodels with lambda expression 
            ICollection<CommentItemVM> hintItemVms = comments.Select(Mapper.Map<Comment, CommentItemVM>).ToList();

            CommentListVM commentListVm = new CommentListVM();

            commentListVm.CommentItemVms = hintItemVms;
            return PartialView("Partials/_CommentList", commentListVm);
        }

        [AjaxCallAF]
        public bool AddComment(int postId, string comment, string type)
        {
            //if()
            //_commentCommandService.AddCommentForPost()
            return false ;
        }

    }
}
