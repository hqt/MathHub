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
using MathHub.Core.Infrastructure;
using MathHub.Web.Models.CommonVM;

namespace MathHub.Web.Controllers
{
    public partial class ProblemController : BaseController
    {

        #region Constructor
        private IProblemQueryService _problemQueryService;
        private IProblemCommandService _problemCommandService;
        private ICommentCommandService _commentCommandService;
        private IAuthenticationService _authenticationService;

        public ProblemController(
            IProblemQueryService problemQueryService,
            ICommentCommandService commentCommandService,
            IProblemCommandService problemCommandService,
            IAuthenticationService authenticationService)
        {
            _problemQueryService = problemQueryService;
            _commentCommandService = commentCommandService;
            _problemCommandService = problemCommandService;
            _authenticationService = authenticationService;
        }
        #endregion

        #region GET Problem
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
        [HttpGet]
        // GET /Problem/Create
        public virtual ActionResult Create()
        {
            return View("Views/CreateProblem");
        }

        // GET /Problem/Detail/1
        public virtual ActionResult Detail(int id)
        {
            Problem targetProblem = _problemQueryService.GetProblemById(id);

            // Map from Model to ViewModel
            DetailProblemVM problemViewModel =
                Mapper.Map<Problem, DetailProblemVM>(targetProblem);

            // problemViewModel.PostVote = tuple;

            problemViewModel.CommentPostVm = new CommentPostVM();
            problemViewModel.CommentPostVm.MainPostId = problemViewModel.Id;
            problemViewModel.CommentPostVm.Type = EnumCommentType.QUESTION;

            problemViewModel.AnswerPostVm = new AnswerPostVM();
            problemViewModel.AnswerPostVm.MainPostId = problemViewModel.Id;

            problemViewModel.HintPostVm = new HintPostVM();
            problemViewModel.HintPostVm.MainPostId = problemViewModel.Id;

            return View("Views/DetailProblem", problemViewModel);
        }

        #endregion

        #region POST Problem
        // POST /Problem/Create
        [Authorize]
        [HttpPost, ValidateInput(false)]
        public virtual ActionResult Create(CreateProblemVM problemVM)
        {
            if (ModelState.IsValid)
            {
                // create new problem
                Problem p = new Problem();
                p.UserId = _authenticationService.GetUserId();
                p.Title = problemVM.Title;
                p.Content = problemVM.Content;
                p.DateCreated = DateTime.Now;
                p.DateModified = DateTime.Now;
                bool res = _problemCommandService.AddProblem(p);
                if (!res)
                {
                    // by some reason. cannot create problem
                    ModelState.AddModelError("create_problem_exception", "This problem cannot be created. Try again later");
                    return View("Views/CreateProblem", problemVM);
                }
                else
                {
                    return Detail(p.Id);
                }
            }
            else
            {
                // if not ModelState valid
                ModelState.AddModelError("model_state_invalid", "Current State is Invalid");
                return View("Views/CreateProblem", problemVM);
            }
        } 
        #endregion
    }
}
