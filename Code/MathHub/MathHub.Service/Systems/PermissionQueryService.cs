using MathHub.Core.Infrastructure.Repository;
using MathHub.Core.Interfaces.Systems;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Service.Systems
{
    public class PermissionQueryService : IPermissionQueryService
    {
        MathHubModelContainer ctx;

        public PermissionQueryService(
            IMathHubDbContext context)
        {
            this.ctx = context.GetDbContext();
        }
    }
}
