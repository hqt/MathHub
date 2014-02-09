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
            IEnumerable<Problem> problems = _problemQueryService.GetAllProblem(Constant.DEFAULT_OFFSET, Constant.DEFAULT_PER_PAGE);
            ListProblemVM model = new ListProblemVM();
            model.problems = problems;
            return View("Views/ListAllProblem", model);
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
            User user = new User();
            user.Username = "Dinh Quang Trung";
            targetProblem.User = user;
            
            for (int i = 0; i < 10; i++)
            {
                Comment cm = new Comment();
                cm.Content = "This is comment";
                cm.User = user;
                targetProblem.Comments.Add(cm);
            }
            
            Mapper.CreateMap<Problem, DetailProblemVM>()
                .ForMember(p => p.VoteUpNum, 
                        m => m.MapFrom(
                        s => _problemQueryService.GetPostVoteUp(s.Id)
                    ))
                    .ForMember(p => p.VoteDownNum,
                        m => m.MapFrom(
                        s => _problemQueryService.GetPostVoteDown(s.Id)
                    ));

            DetailProblemVM problemViewModel =
                Mapper.Map<Problem, DetailProblemVM>(targetProblem);


            return View("Views/DetailProblem", problemViewModel);
        }
    }
}
