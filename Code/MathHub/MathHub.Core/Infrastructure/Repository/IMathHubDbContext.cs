using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Core.Infrastructure.Repository
{
    public interface IMathHubDbContext
    {
        MathHubModelContainer GetDbContext();
    }
}
