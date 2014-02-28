using MathHub.Core.Infrastructure;
using MathHub.Core.Infrastructure.Interfaces.Repository;
using MathHub.Core.Infrastructure.Repository;
using MathHub.Core.Interfaces.Blogs;
using MathHub.Core.Interfaces.Comments;
using MathHub.Core.Interfaces.Discussions;
using MathHub.Core.Interfaces.MainPosts;
using MathHub.Core.Interfaces.Problems;
using MathHub.Core.Interfaces.Systems;
using MathHub.Core.Interfaces.Tags;
using MathHub.Core.Interfaces.Users;
using MathHub.Entity.Entity;
using MathHub.Framework.Infrastructure.Authentication;
using MathHub.Framework.Infrastructure.Repository;
using MathHub.Service.Blogs;
using MathHub.Service.Comments;
using MathHub.Service.Discussions;
using MathHub.Service.MainPosts;
using MathHub.Service.Problems;
using MathHub.Service.Systems;
using MathHub.Service.Tags;
using MathHub.Service.Users;
using StructureMap;
using StructureMap.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MathHub.Framework.Infrastructure.StructureMap
{
    public class StructureMapConfiguration
    {
        public static void Configure()
        {
            ObjectFactory.Initialize(cfg =>
            {
                // interface Authentication 
                cfg.For<IAuthenticationService>()
                    .Use<FormAuthenticationService>();
                // system
                cfg.For<IPermissionQueryService>().Use<PermissionQueryService>();
                cfg.For<IPermissionCommandService>().Use<PermissionCommandService>();
                // user
                cfg.For<IUserQueryService>().Use<UserQueryService>();
                cfg.For<IUserCommandService>().Use<UserCommandService>();

                /** intialize all service interface with its implementation */
                // post
                cfg.For<IMainPostQueryService>().Use<MainPostQueryService>();
                // cfg.For<IMainPostCommandService>().Use<MainPostCommandService>();
                // blog
                cfg.For<IBlogQueryService>().Use<BlogQueryService>();
                cfg.For<IBlogCommandService>().Use<BlogCommandService>();
                // discussion
                cfg.For<IDiscussionQueryService>().Use<DiscussionQueryService>();
                cfg.For<IDiscussionCommandService>().Use<DiscussionCommandService>();
                // problem
                cfg.For<IProblemQueryService>().Use<ProblemQueryService>();
                cfg.For<IProblemCommandService>().Use<ProblemCommandService>();
                // comment
                cfg.For<ICommentQueryService>().Use<CommentQueryService>();
                cfg.For<ICommentCommandService>().Use<CommentCommandService>();
                // tag
                cfg.For<ITagQueryService>().Use<TagQueryService>();
                cfg.For<ITagCommandService>().Use<TagCommandService>();
                
                /** infrastructure */
                // using same Context for One Request
                cfg.For<MathHubModelContainer>().HttpContextScoped();
                cfg.For<IMathHubDbContext>().Use<MathHubDbContext>();
                // use this allow generic on repository
                cfg.For(typeof(IRepository<>)).Use(typeof(GenericRepository<>));
                // Logger
                cfg.For<ILogger>().Use<Logger>();
            });

            ControllerBuilder.Current.SetControllerFactory(new StructureMapControllerFactory());
        }
    }
}
