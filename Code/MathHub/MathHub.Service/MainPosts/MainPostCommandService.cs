using MathHub.Core.Infrastructure;
using MathHub.Core.Infrastructure.Interfaces.Repository;
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
    public class MainPostCommandService : IMainPostCommandService
    {
        #region Constructor
        MathHubModelContainer ctx;
        IRepository<Comment> commentRepository;
        IRepository<Reply> replyRepository;
        IRepository<PostTag> postTagRepository;
        IRepository<Share> shareRepository
        IRepository<FavoritePost> favoritePostRepository;
        IAuthenticationService authenticationService;
        ILogger logger;

        public MainPostCommandService(
            IMathHubDbContext MathHubDbContext,
            IRepository<Comment> commentRepository,
            IRepository<Reply> replyRepository,
            IRepository<PostTag> postTagRepository,
            IRepository<FavoritePost> favoritePostRepository,
            IRepository<Share> shareRepository,
            IAuthenticationService authenticationService,
            ILogger logger)
        {
            this.ctx = MathHubDbContext.GetDbContext();
            this.replyRepository = replyRepository;
            this.commentRepository = commentRepository;
            this.postTagRepository = postTagRepository;
            this.authenticationService = authenticationService;
            this.favoritePostRepository = favoritePostRepository;
            this.shareRepository = shareRepository;
            this.logger = logger;
        }
        #endregion

        #region Add
        public bool AddComment(int postId, Comment comment)
        {
            comment.MainPostId = postId;
            return commentRepository.Insert(comment);
        }

        public bool AddReply(int postId, Reply reply)
        {
            reply.MainPostId = postId;
            return replyRepository.Insert(reply);
        }

        public bool AddTag(int postId, string name)
        {
            // find tag id
            int tagId = ctx.Tags.Where(t => t.Name == name).Select(t => t.Id).FirstOrDefault();
            // not exist this tag in system. ignore
            if (tagId == 0) return false;
            // create new post tag
            PostTag postTag = new PostTag();
            // check if current problem id exist in system or not
            int assertProblemId = ctx.Posts.OfType<Problem>()
                .Where(t => t.Id == postId).Select(t => t.Id).FirstOrDefault();
            if (assertProblemId == 0) return false;
            // create new post tag
            postTag.TagId = tagId;
            postTag.MainPostId = postId;
            return postTagRepository.Insert(postTag);
        }

        public bool AddListTag(int problemId, List<string> name)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Update
        public bool UpdateComment(Comment comment)
        {
            return commentRepository.Update(comment);
        }

        public bool UpdateReply(Reply reply)
        {
            return replyRepository.Update(reply);
        }
        #endregion

        #region Delete
        public bool DeleteComment(Entity.Entity.Comment comment)
        {
            return commentRepository.Delete(comment);
        }

        public bool DeleteTag(int postId, string tagName)
        {
            // find tag id
            int tagId = ctx.Tags.Where(t => t.Name == tagName).Select(t => t.Id).FirstOrDefault();
            // does not exist current tag in system
            if (tagId == 0) return false;
            // find post tag
            PostTag postTag = ctx.PostTags.FirstOrDefault(t => t.TagId == tagId && t.MainPostId == postId);
            // does not exist current post tag (because postId wrong ?)
            if (postTag == null) return false;
            // delete
            return postTagRepository.Delete(postTag);
        }

        public bool DeleteReply(Entity.Entity.Reply reply)
        {
            return replyRepository.Delete(reply);
        }
        #endregion

        #region Modify
        public bool MarkPostAsFavorite(int postId)
        {
            int userId = authenticationService.GetUserId();
            FavoritePost fp = new FavoritePost();
            fp.UserId = userId;
            fp.MainPostId = postId;
            return favoritePostRepository.Insert(fp);
        }

        public bool SharePost(int postId)
        {
            int userId = authenticationService.GetUserId();
            Share s = new Share();
            s.DateCreated = DateTime.Now;
            s.MainPostId = postId;
            s.UserId = userId;
            return shareRepository.Insert(s);
        }

        #endregion    
    }
}
