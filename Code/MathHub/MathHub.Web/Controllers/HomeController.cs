using MathHub.Framework.Controllers;
using System.Web.Mvc;

namespace MathHub.Web.Controllers
{
    public class HomeController : BaseController
    {
        
        /// <summary>
        /// GET /
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
            return Redirect("Problem");
        }

    }
}
