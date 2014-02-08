using MathHub.Core.Interfaces.Problems;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using MathHub.Core.Interfaces.Users;
using MathHub.Core.CommonViewModel.User;
using MathHub.Core.Infrastructure.Repository;

namespace MathHub.Service.Problems
{
    public class ProblemQueryService : IProblemQueryService
    {
        MathHubModelContainer ctx;
        IUserQueryService _userQueryService;

        public ProblemQueryService(
            IMathHubDbContext mathHubDbContext, 
            IUserQueryService userQueryService)
        {
            ctx = mathHubDbContext.GetDbContext();
            this._userQueryService = userQueryService;
        }


        public List<Problem> GetAllProblem(int offSet, int limit)
        {
            return ctx.Posts.OfType<Problem>().OrderBy(b => b.Id).Skip(offSet).Take(limit).ToList();
        }

        public Problem GetProblemById(int id)
        {
            //MathHubModelContainer ctx = new MathHubModelContainer();
            return ctx.Posts.OfType<Problem>().FirstOrDefault(t => t.Id == id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int GetProblemVoteUp(int p)
        {
            return 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetProblemVoteDown(int id)
        {
            return 2;
        }
    }
}
