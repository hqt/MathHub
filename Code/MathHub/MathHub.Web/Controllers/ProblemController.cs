using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MathHub.Core.Interfaces.Problems;
using MathHub.Entity.Entity;
using MathHub.Framework.Controllers;
using AutoMapper;
using MathHub.Web.Models.ProblemVM;
using MathHub.Core.Config;

namespace MathHub.Web.Controllers
{
    public class ProblemController : BaseController
    {
        private IProblemQueryService _problemQueryService;
        public ProblemController(IProblemQueryService problemQueryService)
        {
            _problemQueryService = problemQueryService;
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

        // GET /Problem/Detail/1
        public ActionResult Detail(int? id)
        {
            // ViewBag.Problem = _rproblemService.GetProblemById(id);
            if (!id.HasValue)
            {
                return RedirectToAction("Index");
            }
            Problem targetProblem = _problemQueryService.GetProblemById((int)id);
            targetProblem.Comments = _problemQueryService.GetAllComments(targetProblem.Id).ToList();

            DetailProblemVM problemViewModel =
                Mapper.Map<Problem, DetailProblemVM>(targetProblem);


            return View("Views/DetailProblem", problemViewModel);
        }


        public ActionResult Answer(int Id)
        {
            IEnumerable<Reply> answers = _problemQueryService.GetAllReply(Id, ReplyEnum.ANSWER).AsEnumerable();

           
            ICollection<AnswerItemVM> answerItemVms = answers.Select(Mapper.Map<Reply, AnswerItemVM>).ToList();
            return PartialView("Partials/_AnswerList", answerItemVms);
        }

        public ActionResult Hint(int Id)
        {
            IEnumerable<Reply> hints = _problemQueryService.GetAllReply(Id, ReplyEnum.HINT).AsEnumerable();
            
            
            ICollection<HintItemVM> hintItemVms = hints.Select(Mapper.Map<Reply, HintItemVM>).ToList();
            return PartialView("Partials/_HintList", hintItemVms);
        }
    }
}
