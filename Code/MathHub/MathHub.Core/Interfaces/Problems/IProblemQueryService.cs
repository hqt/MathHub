using MathHub.Core.Interfaces.MainPosts;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Core.Interfaces.Problems
{
    public interface IProblemQueryService : IMainPostQueryService
    {
        IEnumerable<Problem> GetAllProblem(int offSet, int limit);
        Problem GetProblemById(int id);

    }
}
