using MathHub.Core.Infrastructure.Interfaces.Repository;
using MathHub.Core.Interfaces.Problems;
using MathHub.Entity.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test.Problems
{
    [TestClass]
    public class ReplyTest
    {
         public ReplyTest()
        {
            ProblemPreaparation.Preparation();
        }

        [TestMethod]
        public void TestGeneralReply()
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

            // create Reply
            Reply r = new Reply();
            r.Content = "this is an easy reply";
            r.DateCreated = DateTime.Now;
            r.DateModified = DateTime.Now;
            r.UserId = problem.UserId;
            r.Type = ReplyEnum.ANSWER;
            res = problemCommandService.AddReply(problem.Id, r);
            Assert.IsTrue(r.Id > 0);

            // retrieve Reply
            // Get All replies
            IEnumerable<Reply> replies = problemQueryService.GetAllReplies(problem.Id, ReplyEnum.ANSWER, 0, 0);
            bool isExist = false;
            foreach (Reply reply in replies)
            {
                if (reply.Id == r.Id && reply.Content == r.Content)
                {
                    isExist = true;
                    break;
                }
            }
            Assert.IsTrue(isExist);

            // update reply
            r.Content = "this is a very very interesting reply";
            r.DateModified = DateTime.Now;
            res = problemCommandService.UpdateReply(r);
            //test update
            replies = problemQueryService.GetAllReplies(problem.Id, ReplyEnum.ANSWER, 0, 0);
            isExist = false;
            foreach (Reply reply in replies)
            {
                if (reply.Id == r.Id && reply.Content == r.Content && DateTime.Compare(reply.DateModified, reply.DateCreated) > 0) 
                {
                    isExist = true;
                    break;
                }
            }
            Assert.IsTrue(isExist);

            // delete problem
            res = problemCommandService.DeleteReply(r);
            Assert.IsTrue(res);
            //test update
            replies = problemQueryService.GetAllReplies(problem.Id, ReplyEnum.ANSWER, 0, 0);
            isExist = false;
            foreach (Reply reply in replies)
            {
                if (reply.Id == r.Id)
                {
                    isExist = true;
                    break;
                }
            }
            Assert.IsFalse(isExist);

            ProblemPreaparation.CleanUp();
        }
    }
}
