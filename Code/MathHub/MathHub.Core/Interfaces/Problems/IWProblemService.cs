using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathHub.Entity.Entity;

namespace MathHub.Core.Interfaces.Problems
{
    public interface IWProblemService
    {
        void UpdateProblem(Problem problem);
    }
}
