using MathHub.Core.Infrastructure.Interfaces.Repository;
using MathHub.Core.Infrastructure.Repository;
using MathHub.Core.Interfaces.Discussions;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Service.Discussions
{
    public class DiscussionCommandService : IDiscussionCommandService
    {
        MathHubModelContainer ctx;
        IRepository<Discussion> discussionRepository;

        public DiscussionCommandService(
            IRepository<Discussion> discussionRepository,
            IMathHubDbContext context)
        {
            this.ctx = context.GetDbContext();
            this.discussionRepository = discussionRepository;
        }
    }
}
