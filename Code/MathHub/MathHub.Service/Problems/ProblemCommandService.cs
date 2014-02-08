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

        public ProblemCommandService(
            IMathHubDbContext MathHubDbContext,
            IRepository<Problem> problemRepository,
            IRepository<Comment> commentRepository,
            IRepository<Reply> replyRepository,
            IRepository<PostTag> postTagRepository,
            IRepository<Tag> tagRepository
            )
        {
            this.ctx = MathHubDbContext.GetDbContext();
            this.problemRepository = problemRepository;
            this.replyRepository = replyRepository;
            this.commentRepository = commentRepository;
            this.postTagRepository = postTagRepository;
            this.tagRepository = tagRepository;
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
            // find post tag
            PostTag postTag = ctx.PostTags.FirstOrDefault(t => t.TagId == tagId && t.MainPostId == postId);
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
