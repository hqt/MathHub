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
                _problemQueryService.GetAllProblem(
                Constant.DEFAULT_OFFSET, Constant.DEFAULT_PER_PAGE).Where(t => t.User.Id == 784);

            //problems.ToList();

            Mapper.CreateMap<Problem, PreviewProblemVM>();

            ICollection<PreviewProblemVM> problemVms =
                problems.AsEnumerable().Select(Mapper.Map<Problem, PreviewProblemVM>).ToList();



            return View("Views/ListAllProblem", problemVms);
        }

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

            Mapper.CreateMap<Comment, CommentItemVM>();

            //ICollection<CommentItemVM> commentItemVms =
            //    targetProblem.Comments.AsEnumerable()
            //    .Select(Mapper.Map<Comment, CommentItemVM>).ToList();


            Mapper.CreateMap<Problem, DetailProblemVM>()
                .ForMember(p => p.VoteUpNum,
                        m => m.MapFrom(
                        s => _problemQueryService.GetPostVoteUp(s.Id)
                    ))
                    .ForMember(p => p.VoteDownNum,
                        m => m.MapFrom(
                        s => _problemQueryService.GetPostVoteDown(s.Id)
                    ))
                    .ForMember(p => p.Comments,
                        m => m.MapFrom(
                        s => s.Comments.Select(Mapper.Map<Comment, CommentItemVM>)
                    ));

            DetailProblemVM problemViewModel =
                Mapper.Map<Problem, DetailProblemVM>(targetProblem);


            return View("Views/DetailProblem", problemViewModel);
        }


        public ActionResult GetAnswer(int problemId)
        {
            return PartialView("Partials/_AnswerList");
        }

        public ActionResult GetHint(int problemId)
        {
            return PartialView("Partials/_HintList");
        }
    }
}
