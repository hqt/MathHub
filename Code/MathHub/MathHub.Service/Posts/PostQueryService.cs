using MathHub.Core.Infrastructure.Repository;
using MathHub.Core.Interfaces.Posts;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Service.Posts
{
    public class PostQueryService : IPostQueryService
    {
        #region Constructor
        MathHubModelContainer ctx;
        public PostQueryService(IMathHubDbContext mathHubDbContext)
        {
            this.ctx = mathHubDbContext.GetDbContext();
        }
        #endregion

        #region Comment
        public IEnumerable<Comment> GetAllReplyComments(int replyId, int offset, int limit)
        {
            return ctx.Posts
               .OfType<Comment>()
               .Where(t => t.ReplyId == replyId)
               .OrderBy(t => t.DateCreated)
               .Skip(offset).Take(limit);
        }

        public IEnumerable<Comment> GetAllMainPostComments(int mainPostId, int offset, int limit)
        {
            return ctx.Posts
               .OfType<Comment>()
               .Where(t => t.MainPostId == mainPostId)
               .OrderBy(t => t.DateCreated)
               .Skip(offset).Take(limit);
        } 
        #endregion

        #region Vote
        public int GetPostVoteUp(int postId)
        {
            return ctx.Votes.Where(t => t.Type == VoteEnum.UPVOTE).Count(t => t.Post.Id == postId);
        }

        public int GetPostVoteDown(int postId)
        {
            return ctx.Votes.Where(t => t.Type == VoteEnum.UPVOTE).Count(t => t.Post.Id == postId);
        }

        public Tuple<int, int> GetPostVote(int postId)
        {
            int voteUp = ctx.Votes.Where(t => t.Type == VoteEnum.UPVOTE).Count(t => t.Post.Id == postId);
            int voteDown = ctx.Votes.Where(t => t.Type == VoteEnum.DOWNVOTE).Count(t => t.Post.Id == postId);
            return new Tuple<int, int>(voteUp, voteDown);
        } 
        #endregion

        #region Statistic
        public int CountReplyComment(int postId)
        {
            return ctx.Posts.OfType<Comment>().Count(c => c.ReplyId == postId);
        }

        public int CountQuestionComment(int postId)
        {
            return ctx.Posts.OfType<Comment>().Count(c => c.MainPostId == postId);
        }

        public int CountReport(int postId)
        {
            return ctx.Reports.Count(r => r.PostId == postId);
        } 
        #endregion
    }
}
