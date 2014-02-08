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
    public class PermissionCommandService : IPermissionCommandService
    {
        MathHubModelContainer ctx;

        public PermissionCommandService(
            IMathHubDbContext context)
        {
            this.ctx = context.GetDbContext();
        }
    }
}
