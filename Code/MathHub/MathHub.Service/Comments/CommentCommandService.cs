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
    public class CommentCommandService : ICommentCommandService
    {
        IRepository<Comment> commentRepository;
        MathHubModelContainer ctx;

        public CommentCommandService(
            IRepository<Comment> commentRepository,
            IMathHubDbContext context)
        {
            this.ctx = context.GetDbContext();;
            this.commentRepository = commentRepository;
        }

        public bool AddCommentForReply(int replyId, Comment comment)
        {
            comment.ReplyId = replyId;
            comment.MainPostId = 0;
            return commentRepository.Insert(comment);
        }

        public bool AddCommentForPost(int postId, Comment comment)
        {
            comment.MainPostId = postId;
            comment.ReplyId = 0;
            return commentRepository.Insert(comment);
        }
    }
}