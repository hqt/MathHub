using MathHub.Web.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
