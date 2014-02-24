using System;
using MathHub.Core.Infrastructure.Interfaces.Repository;
using MathHub.Core.Interfaces.Problems;
using MathHub.Entity.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureMap;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp.Test.Problems
{
    [TestClass]
    public class CommentTest
    {
        public CommentTest()
        {
            ProblemPreaparation.Preparation();
        }

        [TestMethod]
        public void TestGeneralComment()
        {
            IProblemCommandService problemCommandService = 
                ObjectFactory.GetInstance<IProblemCommandService>();
            IProblemQueryService problemQueryService =
                ObjectFactory.GetInstance<IProblemQueryService>();
            IRepository<Problem> problemRepository =
                ObjectFactory.GetInstance<IRepository<Problem>>();

            bool res;
            // create test problem
            Problem problem = ProblemPreaparation.p;

            // create Comment
            Comment c = new Comment();
            c.Content = "this is an easy comment";
            c.DateCreated = DateTime.Now;
            c.DateModified = DateTime.Now;
            c.UserId = problem.UserId;
            res = problemCommandService.AddComment(problem.Id, c);
            Assert.IsTrue(res);
            Assert.IsTrue(c.Id > 0);

            // retrieve comment
            // Get All Comments
            IEnumerable<Comment> comments = problemQueryService.GetAllComments(problem.Id, 0, 100);
            bool isExist = false;
            foreach (Comment comment in comments)
            {
                if (comment.Id == c.Id && comment.Content == c.Content)
                {
                    isExist = true;
                    break;
                }
            }
            Assert.IsTrue(isExist);

            // update comment
            c.Content = "this is a very very hard comment";
            c.DateModified = DateTime.Now;
            res = problemCommandService.UpdateComment(c);
            //test update
            comments = problemQueryService.GetAllComments(problem.Id, 0, 100);
            isExist = false;
            foreach (Comment comment in comments)
            {
                if (comment.Id == c.Id && comment.Content == c.Content && DateTime.Compare(comment.DateModified, comment.DateCreated) > 0) 
                {
                    isExist = true;
                    break;
                }
            }
            Assert.IsTrue(isExist);

            // delete problem
            res = problemCommandService.DeleteComment(c);
            Assert.IsTrue(res);
            //test update
            comments = problemQueryService.GetAllComments(problem.Id, 0, 100);
            isExist = false;
            foreach (Comment comment in comments)
            {
                if (comment.Id == c.Id)
                {
                    isExist = true;
                    break;
                }
            }
            Assert.IsFalse(isExist);

            // End Test
            ProblemPreaparation.CleanUp();
        }
   
    }
}
