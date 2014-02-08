using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MathHub.Entity.Entity;

namespace MathHub.Web.Models.ProblemVM
{
    public class ListProblemVM
    {
        public IQueryable<Problem> problems { get; set; } 
    }
}