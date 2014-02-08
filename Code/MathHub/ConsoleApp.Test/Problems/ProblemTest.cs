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
    public class ProblemTest
    {
        public ProblemTest()
        {
            StructureMapOfflineConfg.Configure();
        }

        [TestMethod]
        public void TestGeneralProblem()
        {
            IProblemCommandService problemCommandService = 
                ObjectFactory.GetInstance<IProblemCommandService>();
            IProblemQueryService problemQueryService =
                ObjectFactory.GetInstance<IProblemQueryService>();
            IRepository<Problem> problemRepository =
                ObjectFactory.GetInstance<IRepository<Problem>>();

            bool res;

            // create problem
            Problem p = new Problem();
            p.Title = "Console Problem Test One";
            p.Content = "This is a hard hard problem";
            p.DateCreated = DateTime.Now;
            p.DateModified = DateTime.Now;
            p.UserId = 10;
            res = problemCommandService.AddProblem(p) != null ? true : false;
            // problemRepository.Insert(p);
            Assert.IsTrue(res);
            Assert.IsTrue(p.Id > 0);

            // retrieve problem
            Problem np = problemQueryService.GetProblemById(p.Id);
            Assert.AreEqual(np.Title, p.Title);
            Assert.AreEqual(np.Content, np.Content);

            // update problem
            p.Title = "New Problem Title";
            p.Content = "New Content. Ya";
            res = problemCommandService.UpdateProblem(p);
            Problem nps = problemQueryService.GetProblemById(p.Id);
            Assert.AreEqual(p.Id, nps.Id);
            Assert.AreEqual(p.Title, np.Title);
            Assert.AreEqual(p.Content, nps.Content);
            Assert.AreEqual(p.Title, "New Problem Title");

            // delete problem
            problemCommandService.DeleteProblem(np);
            Assert.IsNull(problemQueryService.GetProblemById(p.Id));
        }
   
        [TestMethod]
        public void TestRetrieveProblem()
        {
            IProblemCommandService problemCommandService =
                ObjectFactory.GetInstance<IProblemCommandService>();
            IProblemQueryService problemQueryService =
                ObjectFactory.GetInstance<IProblemQueryService>();
            IRepository<Problem> problemRepository =
                ObjectFactory.GetInstance<IRepository<Problem>>();
        }
    }
}
