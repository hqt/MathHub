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
using MathHub.Core.Interfaces.MainPosts;

namespace MathHub.Service.Problems
{
    public class ProblemQueryService : IProblemQueryService
    {
        #region Constructor
        MathHubModelContainer ctx;
        IUserQueryService _userQueryService;
        IMainPostQueryService _mainPostQueryService;


        public ProblemQueryService(
            IMathHubDbContext mathHubDbContext,
            IUserQueryService userQueryService,
            IMainPostQueryService mainPostQueryService)
        {

            ctx = mathHubDbContext.GetDbContext();
            this._userQueryService = userQueryService;
            this._mainPostQueryService = mainPostQueryService;
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
            return _mainPostQueryService.GetPostVoteUp(postId);
        }

        public int GetPostVoteDown(int postId)
        {
            return _mainPostQueryService.GetPostVoteDown(postId);
        }

        public Tuple<int, int> GetPostVote(int postId)
        {
            return _mainPostQueryService.GetPostVote(postId);
        } 
        #endregion

        #region Tag
        public List<Tag> GetAllPostTag(int postId)
        {
            return _mainPostQueryService.GetAllPostTag(postId);
        }

        public List<string> GetAllPostTagName(int postId)
        {
            return _mainPostQueryService.GetAllPostTagName(postId);
        } 
        #endregion

        #region Comment
        public IEnumerable<Comment> GetAllReplyComments(int replyId, int offset, int limit)
        {
            return _mainPostQueryService.GetAllReplyComments(replyId, offset, limit);
        }

        public IEnumerable<Comment> GetAllMainPostComments(int mainPostId, int offset, int limit)
        {
            return _mainPostQueryService.GetAllMainPostComments(mainPostId, offset, limit);
        }

        #endregion

        #region Reply
        public IEnumerable<Reply> GetAllReplies(int postId, ReplyEnum type, int offset, int limit)
        {
            return _mainPostQueryService.GetAllReplies(postId, type, offset, limit);
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

        public int CountFavorite(int mainPostId)
        {
            return _mainPostQueryService.CountFavorite(mainPostId);
        }


        public int CountReplyComment(int postId)
        {
            return _mainPostQueryService.CountReplyComment(postId);
        }

        public int CountQuestionComment(int postId)
        {
            return _mainPostQueryService.CountQuestionComment(postId);
        }

        public int CountReport(int postId)
        {
            return _mainPostQueryService.CountReport(postId);
        }
        #endregion
    }
}