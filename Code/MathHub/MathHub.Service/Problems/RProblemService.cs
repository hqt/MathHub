using MathHub.Core.Interfaces.Problems;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Service.Problems
{
    public class RProblemService : IRProblemService
    {
        MathHubModelContainer ctx = new MathHubModelContainer();

        public List<Problem> GetAllProblem(int offSet, int limit)
        {
            return ctx.Posts.OfType<Problem>().OrderByDescending(b => b.Id).Skip(offSet).Take(limit).ToList();

        }

        public Problem GetProblemById(int id)
        {
            return (Problem)ctx.Posts.Find(id);
        }

        protected virtual void Dispose(bool disposing)
        {
        }
    }
}
