﻿using MathHub.Entity.Entity;
using MathHub.Framework.Controllers;
using System.Linq;
using System.Data.Entity;
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
            IQueryable<Comment> a = null;
            a.Include(t => t.Id == 10);
            return Redirect("Problem");
        }

    }
}
