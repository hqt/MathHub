using MathHub.Entity.Entity;
using MathHub.Framework.Controllers;
using System.Linq;
using System.Data.Entity;
using System.Web.Mvc;

namespace MathHub.Web.Controllers
{
    public partial class HomeController : BaseController
    {
        
        /// <summary>
        /// GET /
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public virtual ActionResult Index()
        {
            return Redirect("Problem");
        }

    }
}
