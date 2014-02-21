using MathHub.Core.Infrastructure.Interfaces.Repository;
using MathHub.Core.Infrastructure.Repository;
using MathHub.Core.Interfaces.Comments;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Service.Comments
{
    public class CommentQueryService : ICommentQueryService
    {
        IRepository<Comment> commentRepository;
        MathHubModelContainer ctx;

        public CommentQueryService(
            IRepository<Comment> commentRepository,
            IMathHubDbContext context)
        {
            this.ctx = context.GetDbContext();;
            this.commentRepository = commentRepository;
        }
    }
}
