using MathHub.Core.Infrastructure;
using MathHub.Core.Infrastructure.Interfaces.Repository;
using MathHub.Core.Infrastructure.Repository;
using MathHub.Core.Interfaces.Problems;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Service.Problems
{
    public class ProblemCommandService : IProblemCommandService
    {

        #region Constructor
        MathHubModelContainer ctx;
        IRepository<Problem> problemRepository;
        IRepository<Comment> commentRepository;
        IRepository<Reply> replyRepository;
        IRepository<PostTag> postTagRepository;
        IRepository<Tag> tagRepository;
        ILogger logger;

        public ProblemCommandService(
            IMathHubDbContext MathHubDbContext,
            IRepository<Problem> problemRepository,
            IRepository<Comment> commentRepository,
            IRepository<Reply> replyRepository,
            IRepository<PostTag> postTagRepository,
            IRepository<Tag> tagRepository,
            ILogger logger
            )
        {
            this.ctx = MathHubDbContext.GetDbContext();
            this.problemRepository = problemRepository;
            this.replyRepository = replyRepository;
            this.commentRepository = commentRepository;
            this.postTagRepository = postTagRepository;
            this.tagRepository = tagRepository;
            this.logger = logger;
        } 
        #endregion

        #region Add
        public bool AddProblem(Entity.Entity.Problem problem)
        {
            return problemRepository.Insert(problem);

        }

        public bool AddComment(int problemId, Comment comment)
        {
            comment.MainPostId = problemId;
            return commentRepository.Insert(comment);
        }

        public bool AddReply(int problemId, Reply reply)
        {
            reply.MainPostId = problemId;
            return replyRepository.Insert(reply);
        }


        public bool AddTag(int problemId, string name)
        {
            // find tag id
            int tagId = ctx.Tags.Where(t => t.Name == name).Select(t => t.Id).FirstOrDefault();
            // not exist this tag in system. ignore
            if (tagId == 0) return false;
            // create new post tag
            PostTag postTag = new PostTag();
            // check if current problem id exist in system or not
            int assertProblemId = ctx.Posts.OfType<Problem>()
                .Where(t => t.Id == problemId).Select(t => t.Id).FirstOrDefault();
            if (assertProblemId == 0) return false;
            // create new post tag
            postTag.TagId = tagId;
            postTag.MainPostId = problemId;
            return postTagRepository.Insert(postTag);   
        }

        public bool AddListTag(int problemId, List<string> name)
        {
            throw new NotImplementedException();  
        }
        #endregion

        #region Update
        public bool UpdateProblem(Problem problem)
        {
            return problemRepository.Update(problem);
        }

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
        public bool DeleteComment(Comment comment)
        {
            return commentRepository.Delete(comment);
        }

        public bool DeleteProblem(Problem problem)
        {
            return problemRepository.Delete(problem);
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

        public bool DeleteReply(Reply reply)
        {
            return replyRepository.Delete(reply);
        }
        #endregion
    }
}
