using MathHub.Core.Interfaces.Problems;
using MathHub.Core.Interfaces.Tags;
using MathHub.Core.Interfaces.Users;
using MathHub.Entity.Entity;
using MathHub.Service.Problems;
using MathHub.Service.Tags;
using MathHub.Service.Users;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test.Problems
{
    public static class ProblemPreaparation
    {
        public static User u;
        public static Problem p;
        public static Tag t;

        public static void Preparation()
        {
            StructureMapOfflineConfg.Configure();
            IUserCommandService userCommandService =
                ObjectFactory.GetInstance<UserCommandService>();
            IProblemCommandService problemCommandService =
                ObjectFactory.GetInstance<ProblemCommandService>();
            ITagCommandService tagCommandService =
                ObjectFactory.GetInstance<TagCommandService>();
            // create a user
            u = new User();
            u.Username = "Huynh Quang Thao";
            u.Score = 0;
            userCommandService.InsertUser(u, null, null);
            Assert.IsTrue(u.Id > 0);
            // create an avatar link
            Image img = new Image();
            img.Description = "this is a sample url";
            img.Url = "www.google.com";
            
            
            // create a new problem
            p = new Problem();
            p.Title = "This is a hard problem"; 
            p.Content = "This problem is so hard";
            p.DateCreated = DateTime.Now;
            p.DateModified = DateTime.Now;
            p.UserId = u.Id;
            problemCommandService.AddProblem(p);
            Assert.IsTrue(p.Id > 0);

            // create custom tag
            t = new Tag();
            t.Name = "Combinatoric";
            t.Description = "this is a hard tag";
            t.CreatorId = u.Id;
            t.DateCreated = DateTime.Now;
            t.DateModified = DateTime.Now;
            tagCommandService.CreateNewTag(t);

        }

        public static void CleanUp()
        {
            IUserCommandService userCommandService =
                ObjectFactory.GetInstance<UserCommandService>();
            IProblemCommandService problemCommandService =
                ObjectFactory.GetInstance<ProblemCommandService>();
              ITagCommandService tagCommandService =
                ObjectFactory.GetInstance<TagCommandService>();
            // clear data
            // clear problem
            problemCommandService.DeleteProblem(p);
            // clear user
            userCommandService.DeleteUser(u);
            // clear tag
            tagCommandService.RemoveTag(t);
        }
    }
}
