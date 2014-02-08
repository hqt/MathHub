using MathHub.Core.Infrastructure.Interfaces.Repository;
using MathHub.Core.Interfaces.Problems;
using MathHub.Entity.Entity;
using MathHub.Web.Framework.Infrastructure.StructureMap;
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
    public class CommentTest
    {
        public CommentTest()
        {
            StructureMapOfflineConfg.Configure();
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
            Problem problem = problemQueryService.GetProblemById(2);

            // create Comment
            Comment c = new Comment();
            c.Content = "this is an easy comment";
            c.DateCreated = DateTime.Now;
            c.DateModified = DateTime.Now;
            c.UserId = 10;
            res = problemCommandService.AddCommentForProblem(problem.Id, c) != null ? true : false;
            // problemRepository.Insert(p);
            // Assert.IsTrue(res);
            Assert.IsTrue(c.Id > 0);

            //// retrieve problem
            //Problem np = problemQueryService.GetProblemById(p.Id);
            //Assert.AreEqual(np.Title, p.Title);
            //Assert.AreEqual(np.Content, np.Content);

            //// update problem
            //p.Title = "New Problem Title";
            //p.Content = "New Content. Ya";
            //res = problemCommandService.UpdateProblem(p);
            //Problem nps = problemQueryService.GetProblemById(p.Id);
            //Assert.AreEqual(p.Id, nps.Id);
            //Assert.AreEqual(p.Title, np.Title);
            //Assert.AreEqual(p.Content, nps.Content);
            //Assert.AreEqual(p.Title, "New Problem Title");

            //// delete problem
            //problemCommandService.DeleteProblem(np);
            //Assert.IsNull(problemQueryService.GetProblemById(p.Id));
        }
   
    }
}
