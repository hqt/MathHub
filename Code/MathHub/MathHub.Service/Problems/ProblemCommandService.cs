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
        MathHubModelContainer ctx;
        IRepository<Problem> problemRepository;
        IRepository<Comment> commentRepository;
        IRepository<Reply> replyRepository;

        public ProblemCommandService(
            IMathHubDbContext MathHubDbContext,
            IRepository<Problem> problemRepository,
            IRepository<Comment> commentRepository,
            IRepository<Reply> replyRepository
            )
        {
            this.ctx = MathHubDbContext.GetDbContext();
            this.problemRepository = problemRepository;
            this.replyRepository = replyRepository;
            this.commentRepository = commentRepository;
        }

        public bool UpdateProblem(Problem problem)
        {
            //if (problem == null) {
            //    throw new ArgumentException("Cannot add a null entity");
            //}

            ////MathHubModelContainer ctx = new MathHubModelContainer();
            ////ctx.Configuration.LazyLoadingEnabled = false;
            ////ctx.Configuration.ProxyCreationEnabled = false;

            //DbEntityEntry attachtedEntrys = ctx.Entry(problem);
            //// Find Currently Entity Entry in Context
            //DbEntityEntry entry = ctx.Entry<Post>(problem);

            //// if does not attatch yet.
            //if (entry.State == EntityState.Detached)
            //{
            //    // new entity here is wrapped by proxy
            //    Problem attachedProblem = ctx.Set<Problem>().Find(problem.Id);
            //    if (attachedProblem != null)
            //    {
            //        // get curently DBEntityEntry with AttachedProblem
            //        DbEntityEntry attachtedEntry = ctx.Entry(attachedProblem);
            //        attachtedEntry.CurrentValues.SetValues(problem);
            //        attachtedEntry.State = EntityState.Modified;
            //    }
            //    else
            //    {
            //        //entry.State = EntityState.Modified;
            //        //entry.CurrentValues.SetValues(problem);
            //        return false;
            //    }
            //}
            //else
            //{
            //    // this entity has been attached to current context
            //    entry.CurrentValues.SetValues(problem);
            //    entry.State = EntityState.Modified;
            //}

            //ctx.SaveChanges();
            //return true;
            
            problemRepository.Update(problem);
            return true;
        }

        public Problem AddProblem(Entity.Entity.Problem problem)
        {
            //ctx.Posts.Attach(problem);
            //ctx.Entry(problem).State = EntityState.Added;
            //ctx.SaveChanges();
            problemRepository.Insert(problem);
            return problem;

        }

        public Problem AddCommentForProblem(int problemId, Comment comment)
        {
            comment.MainPostId = problemId;
            commentRepository.Insert(comment);
            return null;
        }

        public Problem AddReplyForProblem(int problemId, Reply reply)
        {
            throw new NotImplementedException();
        }

        public bool UpdateComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public bool UpdateReply(Reply reply)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCommentOfProblem(int problemId, Comment comment)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProblem(Problem problem)
        {
            //if (problem == null)
            //{
            //    throw new ArgumentException("Cannot delete a null entity");
            //}

            //// MathHubModelContainer ctx = new MathHubModelContainer();
            //// ctx.Configuration.LazyLoadingEnabled = false;
            //// ctx.Configuration.ProxyCreationEnabled = false;

            //DbEntityEntry attachtedEntrys = ctx.Entry(problem);
            //// Find Currently Entity Entry in Context
            //DbEntityEntry entry = ctx.Entry<Post>(problem);

            //// if does not attatch yet.
            //if (entry.State == EntityState.Detached)
            //{
            //    // new entity here is wrapped by proxy
            //    Problem attachedProblem = ctx.Set<Problem>().Find(problem.Id);
            //    if (attachedProblem != null)
            //    {
            //        // get curently DBEntityEntry with AttachedProblem
            //        DbEntityEntry attachtedEntry = ctx.Entry(attachedProblem);
            //        attachtedEntry.CurrentValues.SetValues(problem);
            //        attachtedEntry.State = EntityState.Deleted;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //else
            //{
            //    // this entity has been attached to current context
            //    entry.CurrentValues.SetValues(problem);
            //    entry.State = EntityState.Deleted;
            //}

            //// ctx.SaveChanges();
            //return true;

            return problemRepository.Delete(problem);
        }

    }
}
