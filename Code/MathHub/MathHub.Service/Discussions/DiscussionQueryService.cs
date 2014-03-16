using MathHub.Core.Infrastructure.Interfaces.Repository;
using MathHub.Core.Infrastructure.Repository;
using MathHub.Core.Interfaces.Discussions;
using MathHub.Core.Interfaces.MainPosts;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Service.Discussions
{
    public class DiscussionQueryService : IDiscussionQueryService
    {
        #region Constructor
        MathHubModelContainer ctx;
        IRepository<Discussion> _discussionRepository;
        IMainPostQueryService _mainPostQuerySerivce;

        public DiscussionQueryService(
            IRepository<Discussion> discussionRepository,
            IMathHubDbContext context,
            IMainPostQueryService mainPostQuerySerivce)
        {
            this.ctx = context.GetDbContext();
            this._discussionRepository = discussionRepository;
            this._mainPostQuerySerivce = mainPostQuerySerivce;
        } 
        #endregion

        #region Tag
        public List<Tag> GetAllMainPostTag(int postId)
        {
            return _mainPostQuerySerivce.GetAllPostTag(postId);
        } 
        #endregion

        #region Vote
        public int GetPostVoteUp(int postId)
        {
            return _mainPostQuerySerivce.GetPostVoteUp(postId);
        }

        public int GetPostVoteDown(int postId)
        {
            return _mainPostQuerySerivce.GetPostVoteDown(postId);
        }

        public Tuple<int, int> GetPostVote(int postId)
        {
            return _mainPostQuerySerivce.GetPostVote(postId);
        } 
        #endregion

        #region Discussion
        public IEnumerable<Discussion> GetNewestDiscussions(int offSet, int limit)
        {
            return ctx.Posts.OfType<Discussion>()
               .OrderByDescending(b => b.DateCreated)
               .Skip(offSet)
               .Take(limit);
        }

        public Discussion GetDiscussionById(int id)
        {
            return ctx.Posts.OfType<Discussion>().FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<Discussion> GetDiscussionssByUserId(int userId, int limit)
        {
            return ctx.Posts.OfType<Discussion>().Where(p => p.UserId == userId).Take(limit);
        } 
        #endregion

        #region Tag
        public List<Tag> GetAllPostTag(int postId)
        {
            return _mainPostQuerySerivce.GetAllPostTag(postId);
        }

        public List<string> GetAllPostTagName(int postId)
        {
            return _mainPostQuerySerivce.GetAllPostTagName(postId);
        } 
        #endregion

        #region Comment
        public IEnumerable<Comment> GetAllReplyComments(int replyId, int offset, int limit)
        {
            return _mainPostQuerySerivce.GetAllReplyComments(replyId, offset, limit);
        }

        public IEnumerable<Comment> GetAllMainPostComments(int mainPostId, int offset, int limit)
        {
            return _mainPostQuerySerivce.GetAllMainPostComments(mainPostId, offset, limit);
        }
        #endregion

        #region Reply
        public IEnumerable<Reply> GetAllReplies(int postId, ReplyEnum type, int offset, int limit)
        {
            return _mainPostQuerySerivce.GetAllReplies(postId, ReplyEnum.DEFAULT, offset, limit);
        } 
        #endregion

        #region Statistic
        public Tuple<int, int, int> GetPostSocialReport(int postId)
        {
            return _mainPostQuerySerivce.GetPostSocialReport(postId);
        }

        public Tuple<int, int, int> GetPostReplyReport(int postId)
        {
            return _mainPostQuerySerivce.GetPostReplyReport(postId);
        }

        public int CountFavorite(int mainPostId)
        {
            return _mainPostQuerySerivce.CountFavorite(mainPostId);
        }

        public int CountReplyComment(int postId)
        {
            return _mainPostQuerySerivce.CountReplyComment(postId);
        }

        public int CountQuestionComment(int postId)
        {
            return _mainPostQuerySerivce.CountQuestionComment(postId);
        }

        public int CountReport(int postId)
        {
            return _mainPostQuerySerivce.CountReport(postId);
        }
        #endregion
    }
}
