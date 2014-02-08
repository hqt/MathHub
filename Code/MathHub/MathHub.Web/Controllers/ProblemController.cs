using System.Web.Mvc;
using MathHub.Framework.Controllers;
using MathHub.Web.Models;

namespace MathHub.Web.Controllers
{
    public class ProblemController : BaseController
    {
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
            return View("Views/DetailProblem", 
                new DetailProblemViewModel((int) id));
        }
    }
}
