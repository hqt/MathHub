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
        public IEnumerable<Problem> GetAllProblem(int offSet, int limit)
        {
            return ctx.Posts.OfType<Problem>().OrderBy(b => b.Id).Skip(offSet).Take(limit);
        }

        public Problem GetProblemById(int id)
        {
            return ctx.Posts.OfType<Problem>().FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<Problem> GetProblemsByUserId(int userId, int limit)
        {
            throw new NotImplementedException();
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
        public IEnumerable<Comment> GetAllComments(int postId)
        {
            return ctx.Posts.OfType<Comment>().Where(t => t.MainPostId == postId).AsEnumerable();
        } 
        #endregion

        #region Reply
        public IEnumerable<Reply> GetAllReply(int postId, ReplyEnum type)
        {
            return ctx.Posts.OfType<Reply>().Where(t => t.MainPostId == postId && t.Type == type);
        } 
        #endregion
    }
}
