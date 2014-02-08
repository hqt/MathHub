using ConsoleApp.Test.Problems;
using MathHub.Core.Infrastructure;
using MathHub.Core.Infrastructure.Interfaces.Repository;
using MathHub.Entity.Entity;
using MathHub.Framework.Utils;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            InitIoC();
           // Console.WriteLine("Hello World");
           // StructureMapOfflineConfg.Configure();
           // // ProblemTest.TestProblem();

           // IRepository<Post> postRepository =
           //     ObjectFactory.GetInstance<IRepository<Post>>();
           //Post post = postRepository.GetById(1);
           //Console.WriteLine("Content: " + post.Content);

           //IRepository<Problem> problemRepository =
           //    ObjectFactory.GetInstance<IRepository<Problem>>();
           
           // //Problem p = problemRepository.GetById(2);
           ////Console.WriteLine("Content: " + p.Content);

           //Problem p = new Problem();
           //p.Title = "Console Problem Test Two";
           //p.Content = "This is an easy easy problem";
           //p.DateCreated = DateTime.Now;
           //p.DateModified = DateTime.Now;
           //p.UserId = 10;
           //problemRepository.Insert(p);

            // TestReflectionAPI();

            //ILogger logger = ObjectFactory.GetInstance<Logger>();
            //logger.Error("Error", "This is a main error we have meet");
            //Console.ReadLine();

            ProblemTest t = new ProblemTest();
            t.TestGeneralProblem();

            Console.WriteLine("Finish Console Test");
            Console.ReadLine();

        }

        private static void TestReflectionAPI()
        {
            var func = ReflectionUtils.GetExpressionFindId<Problem>(2);
            var func1 = ReflectionUtils.GetExpressionFindId<Post>(2);
            MathHubModelContainer ctx = new MathHubModelContainer();
            Post p = ctx.Posts.Where(func1).FirstOrDefault();
            Problem problem = ctx.Posts.OfType<Problem>().Where(func).FirstOrDefault();
            Console.WriteLine(p.Content);
            Console.WriteLine(problem.Title);
            Console.ReadLine();
        }

        private static void InitIoC()
        {
            StructureMapOfflineConfg.Configure();
        }
    }
}
