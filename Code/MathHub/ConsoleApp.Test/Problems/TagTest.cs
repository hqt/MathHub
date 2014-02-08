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
    public class TagTest
    {
          public TagTest()
        {
            StructureMapOfflineConfg.Configure();
        }

        [TestMethod]
        public void TestGeneralTag()
        {
            IProblemCommandService problemCommandService = 
                ObjectFactory.GetInstance<IProblemCommandService>();
            IProblemQueryService problemQueryService =
                ObjectFactory.GetInstance<IProblemQueryService>();
            IRepository<Problem> problemRepository =
                ObjectFactory.GetInstance<IRepository<Problem>>();

            bool res;
            // create test problem
            Problem problem = problemQueryService.GetProblemById(2);

            // create PostTag
            String title = "Combinatoric";
            res = problemCommandService.AddTag(problem.Id, title);
            Assert.IsTrue(res);

            // retrieve PostTag
            // Get All post tags
            List<String> tags = problemQueryService.GetAllPostTagName(problem.Id);
            bool isExist = false;
            foreach (String tag in tags)
            {
                if (tag == title)
                {
                    isExist = true;
                    break;
                }
            }
            Assert.IsTrue(isExist);

            // update tag
            // update ? hope not
            //r.Content = "this is a very very interesting reply";
            //r.DateModified = DateTime.Now;
            //res = problemCommandService.UpdateReply(r);
            ////test update
            //replies = problemQueryService.GetAllReply(problem.Id, ReplyEnum.ANSWER);
            //isExist = false;
            //foreach (Reply reply in replies)
            //{
            //    if (reply.Id == r.Id && reply.Content == r.Content && DateTime.Compare(reply.DateModified, reply.DateCreated) > 0) 
            //    {
            //        isExist = true;
            //        break;
            //    }
            //}
            //Assert.IsTrue(isExist);

            // delete tag
            res = problemCommandService.DeleteTag(problem.Id, title);
            Assert.IsTrue(res);
            //test update
            tags = problemQueryService.GetAllPostTagName(problem.Id);
            isExist = false;
            foreach (String tag in tags)
            {
                if (tag == title)
                {
                    isExist = true;
                    break;
                }
            }
            Assert.IsFalse(isExist);
        }

        [TestMethod]
        public void TestExceptionTag()
        {
            IProblemCommandService problemCommandService =
               ObjectFactory.GetInstance<IProblemCommandService>();
            IProblemQueryService problemQueryService =
                ObjectFactory.GetInstance<IProblemQueryService>();
            IRepository<Problem> problemRepository =
                ObjectFactory.GetInstance<IRepository<Problem>>();

            bool res;
            // create test problem
            Problem problem = problemQueryService.GetProblemById(2);

            // create PostTag
            // i. wrong tag
            String wrongTitle = "Wrong-Combinatoric";
            String trueTitle = "Combinatoric";
            int wrongProblemId = 999999999;
            res = problemCommandService.AddTag(problem.Id, wrongTitle);
            Assert.IsFalse(res);
            // ii. wrong problem id
            res = problemCommandService.AddTag(wrongProblemId, trueTitle);
            Assert.IsFalse(res);
            /// iii. wrong both
            res = problemCommandService.AddTag(wrongProblemId, wrongTitle);
            Assert.IsFalse(res);

            // retrieve PostTag
            // Get All post tags
            try
            {
                List<String> tags = problemQueryService.GetAllPostTagName(wrongProblemId);
            }
            catch (Exception e)
            {
                Assert.Fail("Should not throw exception");
            }
            
            // update tag
            // update ? hope not
            //r.Content = "this is a very very interesting reply";
            //r.DateModified = DateTime.Now;
            //res = problemCommandService.UpdateReply(r);
            ////test update
            //replies = problemQueryService.GetAllReply(problem.Id, ReplyEnum.ANSWER);
            //isExist = false;
            //foreach (Reply reply in replies)
            //{
            //    if (reply.Id == r.Id && reply.Content == r.Content && DateTime.Compare(reply.DateModified, reply.DateCreated) > 0) 
            //    {
            //        isExist = true;
            //        break;
            //    }
            //}
            //Assert.IsTrue(isExist);

            // delete tag
            // i. wrong title
            res = problemCommandService.DeleteTag(problem.Id, wrongTitle);
            // ii. wrong problem id
            res = problemCommandService.DeleteTag(wrongProblemId, trueTitle);
            /// iii. wrong both :">
            res = problemCommandService.DeleteTag(wrongProblemId, wrongTitle);
            Assert.IsFalse(res);
        }
    }
}
