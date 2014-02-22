using MathHub.Core.Interfaces.Problems;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using MathHub.Core.Interfaces.Users;
using MathHub.Core.Infrastructure.Repository;
using MathHub.Core.Config;

namespace MathHub.Service.Problems
{
    public class ProblemQueryService : IProblemQueryService
    {
        #region Constructor
        MathHubModelContainer ctx;
        IUserQueryService _userQueryService;

        public ProblemQueryService(
            IMathHubDbContext mathHubDbContext,
            IUserQueryService userQueryService)
        {

            ctx = mathHubDbContext.GetDbContext();
            this._userQueryService = userQueryService;
        } 
        #endregion


        #region Problem
        public IEnumerable<Problem> GetNewestProblems(int offSet, int limit)
        {
            return ctx.Posts.OfType<Problem>()
                .OrderByDescending(b => b.DateCreated)
                .Skip(offSet)
                .Take(limit);
        }

        public Problem GetProblemById(int id)
        {
            return ctx.Posts.OfType<Problem>().FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<Problem> GetProblemsByUserId(int userId, int limit)
        {
            return ctx.Posts.OfType<Problem>().Where(p => p.UserId == userId).Take(limit);
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

        #region Blog
        public IEnumerable<Blog> GetRelatedBlogsByProblemId(int problemId, int limit)
        {
            return ctx.BlogProblems
                .Where(b => b.ProblemId == problemId)
                .OrderByDescending(b => b.Blog.DateCreated)
                .Take(limit)
                .Select(b => b.Blog);
        } 
        #endregion

        #region statistic
        /// <summary>
        /// return :
        ///     number of favorites
        ///     number of reports
        ///     number of shares
        /// </summary>
        public Tuple<int, int, int> GetPostSocialReport(int postId)
        {
            int favorites = ctx.FavoritePosts.Count(f => f.MainPostId == postId);
            int reports = ctx.Reports.Count(r => r.PostId == postId);
            int shares = ctx.Shares.Count(s => s.MainPostId == postId);
            return new Tuple<int, int, int>(favorites, reports, shares);
        }

        /// <summary>
        /// returns :
        ///     number of comments
        ///     number of answers
        ///     number of hints
        /// </summary>
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