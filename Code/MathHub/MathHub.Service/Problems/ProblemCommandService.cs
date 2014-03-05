using MathHub.Core.Infrastructure;
using MathHub.Core.Infrastructure.Interfaces.Repository;
using MathHub.Core.Infrastructure.Repository;
using MathHub.Core.Interfaces.MainPosts;
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
        IMainPostCommandService mainPostCommandService;
        ILogger logger;

        public ProblemCommandService(
            IMathHubDbContext MathHubDbContext,
            IRepository<Problem> problemRepository,
            IMainPostCommandService mainPostCommandService,
            ILogger logger
            )
        {
            this.ctx = MathHubDbContext.GetDbContext();
            this.problemRepository = problemRepository;
            this.mainPostCommandService = mainPostCommandService;
            this.logger = logger;
        } 
        #endregion

        #region Add
        public bool AddProblem(Problem problem)
        {
            return problemRepository.Insert(problem);

        }

        public bool AddComment(int problemId, Comment comment)
        {
            return mainPostCommandService.AddComment(problemId, comment);
        }

        public bool AddReply(int problemId, Reply reply)
        {
            return mainPostCommandService.AddReply(problemId, reply);
        }


        public bool AddTag(int problemId, string name)
        {
            return mainPostCommandService.AddTag(problemId, name);
        }

        public bool AddListTag(int problemId, List<string> names)
        {
            return mainPostCommandService.AddListTag(problemId, names); 
        }
        #endregion

        #region Update
        public bool UpdateProblem(Problem problem)
        {
            return problemRepository.Update(problem);
        }

        public bool UpdateComment(Comment comment)
        {
            return mainPostCommandService.UpdateComment(comment);
        }

        public bool UpdateReply(Reply reply)
        {
            return mainPostCommandService.UpdateReply(reply);
        }
        #endregion

        #region Delete
        public bool DeleteComment(Comment comment)
        {
            return mainPostCommandService.DeleteComment(comment);
        }

        public bool DeleteProblem(Problem problem)
        {
            return problemRepository.Delete(problem);
        }

        public bool DeleteTag(int postId, string tagName)
        {
            return mainPostCommandService.DeleteTag(postId, tagName);
        }

        public bool DeleteReply(Reply reply)
        {
            return mainPostCommandService.DeleteReply(reply);
        }
        #endregion

        #region Modify
        public bool MarkPostAsFavorite(int postId)
        {
            return mainPostCommandService.MarkPostAsFavorite(postId);
        }

        public bool SharePost(int postId)
        {
            return mainPostCommandService.SharePost(postId);
        } 
        #endregion
    }
}
