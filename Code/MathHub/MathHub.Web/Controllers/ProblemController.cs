using System.Web.Mvc;
using MathHub.Core.Interfaces.Problems;
using MathHub.Entity.Entity;
using MathHub.Framework.Controllers;
using AutoMapper;
using MathHub.Web.Models.ProblemVM;

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
            return View("Views/ListAllProblem");
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
            
            Problem targetProblem = _problemQueryService.GetProblemById((int) id);

            User user = new User();
            user.Username = "Dinh Quang Trung";
            targetProblem.User = user;

            Mapper.CreateMap<Problem, DetailProblemVM>()
                .ForMember(p => p.VoteUpNum, 
                        m => m.MapFrom(
                        s => _problemQueryService.GetProblemVoteUp(s.Id)
                    ))
                    .ForMember(p => p.VoteDownNum,
                        m => m.MapFrom(
                        s => _problemQueryService.GetProblemVoteDown(s.Id)
                    ));

            DetailProblemVM problemViewModel =
                Mapper.Map<Problem, DetailProblemVM>(targetProblem);


            return View("Views/DetailProblem", problemViewModel);
        }
    }
}
