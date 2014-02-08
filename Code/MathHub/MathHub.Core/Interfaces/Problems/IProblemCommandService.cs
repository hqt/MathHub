using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathHub.Entity.Entity;
using MathHub.Core.Interfaces.MainPosts;

namespace MathHub.Core.Interfaces.Problems
{
    public interface IProblemCommandService : IMainPostCommandService
    {
        /// <summary>
        /// Insert 
        /// </summary>
        bool AddProblem(Problem problem);
        

        /// <summary>
        /// Update
        /// </summary>
        bool UpdateProblem(Problem problem);
       

        /// <summary>
        /// Delete
        /// </summary>
        bool DeleteProblem(Problem problem);
    }
}
