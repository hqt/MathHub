using MathHub.Core.Infrastructure.Repository;
using MathHub.Core.Interfaces.MainPosts;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Service.MainPosts
{
    public class MainPostQueryService : IMainPostQueryService
    {
        #region Constructor
        MathHubModelContainer ctx;

        public MainPostQueryService(IMathHubDbContext mathHubDbContext)
        {
            this.ctx = mathHubDbContext.GetDbContext();
        } 
        #endregion

        #region Tag
        public List<Tag> GetAllPostTag(int postId)
        {
            return ctx.PostTags
                .Where(t => t.MainPostId == postId)
                .Select(t => t.Tag).ToList();
        }

        public List<string> GetAllPostTagName(int postId)
        {
            return ctx.PostTags
                .Where(t => t.MainPostId == postId)
                .Select(t => t.Tag.Name).ToList();
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

        #region Comment
        public IEnumerable<Comment> GetAllComments(int postId, int offset, int limit)
        {
            return ctx.Posts
               .OfType<Comment>()
               .Where(t => t.MainPostId == postId)
               .OrderBy(t => t.DateCreated)
               .Skip(offset).Take(limit);
        } 
        #endregion

        #region Reply
        public IEnumerable<Reply> GetAllReplies(int postId, ReplyEnum type, int offset, int limit)
        {
            if (offset == 0 && limit == 0)
            {
                return ctx.Posts.OfType<Reply>().Where(t => t.MainPostId == postId && t.Type == type);
            }
            else
            {
                return ctx.Posts
                    .OfType<Reply>()
                    .Where(t => t.MainPostId == postId && t.Type == type)
                    .OrderBy(t => t.DateCreated)
                    .Skip(offset)
                    .Take(limit);
            }
        } 
        #endregion

        #region Post
        public MainPost GetMainPostDetail(int postId)
        {
            throw new NotImplementedException();
        }

        public Tuple<int, int, int> GetPostSocialReport(int postId)
        {
            int favorites = ctx.FavoritePosts.Count(f => f.MainPostId == postId);
            int reports = ctx.Reports.Count(r => r.PostId == postId);
            int shares = ctx.Shares.Count(s => s.MainPostId == postId);
            return new Tuple<int, int, int>(favorites, reports, shares);
        }

        public Tuple<int, int, int> GetPostReplyReport(int postId)
        {
            int comments = ctx.Posts.OfType<Comment>().Count(c => c.MainPostId == postId);
            int answers = ctx.Posts.OfType<Reply>().Count(r => r.MainPostId == postId && r.Type == ReplyEnum.ANSWER);
            int hints = ctx.Posts.OfType<Reply>().Count(r => r.MainPostId == postId && r.Type == ReplyEnum.HINT);
            return new Tuple<int, int, int>(comments, answers, hints);
        } 
        #endregion
    }
}
