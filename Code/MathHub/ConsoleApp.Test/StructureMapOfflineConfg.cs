using MathHub.Core.Infrastructure;
using MathHub.Core.Infrastructure.Interfaces.Repository;
using MathHub.Core.Infrastructure.Repository;
using MathHub.Core.Interfaces.Problems;
using MathHub.Core.Interfaces.Users;
using MathHub.Entity.Entity;
using MathHub.Core.Interfaces.Blogs;
using MathHub.Core.Interfaces.Discussions;
using MathHub.Core.Interfaces.Systems;
using MathHub.Core.Interfaces.Tags;
using MathHub.Framework.Infrastructure;
using MathHub.Framework.Infrastructure.Authentication;
using MathHub.Framework.Infrastructure.Repository;
using MathHub.Service.Blogs;
using MathHub.Service.Discussions;
using MathHub.Service.Problems;
using MathHub.Service.Systems;
using MathHub.Service.Tags;
using MathHub.Service.Users;
using StructureMap;

namespace ConsoleApp.Test
{
    public static class StructureMapOfflineConfg
    {
        public static void Configure()
        {
            ObjectFactory.Initialize(cfg =>
            {
                // interface Authentication should validate in one Session
                cfg.For<IAuthenticationService>()
                    //.LifecycleIs(Lifecycles.GetLifecycle(InstanceScope.HttpSession))
                    .Use<MockupAuthenticationService>();

                /** intialize all service interface with its implementation */
                // blog
                cfg.For<IBlogQueryService>().Use<BlogQueryService>();
                cfg.For<IBlogCommandService>().Use<BlogCommandService>();
                // discussion
                cfg.For<IDiscussionQueryService>().Use<DiscussionQueryService>();
                cfg.For<IDiscussionCommandService>().Use<DiscussionCommandService>();
                // problem
                cfg.For<IProblemQueryService>().Use<ProblemQueryService>();
                cfg.For<IProblemCommandService>().Use<ProblemCommandService>();
                // system
                cfg.For<IPermissionQueryService>().Use<PermissionQueryService>();
                cfg.For<IPermissionCommandService>().Use<PermissionCommandService>();
                // tag
                cfg.For<ITagQueryService>().Use<TagQueryService>();
                cfg.For<ITagCommandService>().Use<TagCommandService>();
                // user
                cfg.For<IUserQueryService>().Use<UserQueryService>();
                cfg.For<IUserCommandService>().Use<UserCommandService>();

                /** infrastructure */
                // using same Context for One Request
                cfg.For<MathHubModelContainer>().HttpContextScoped();
                cfg.For<IMathHubDbContext>().Singleton().Use<MathHubDbContext>();
                // use this allow generic on repository
                cfg.For(typeof(IRepository<>)).Use(typeof(GenericRepository<>));
                // Logger
                cfg.For<ILogger>().Use<Logger>();
            });

            // ControllerBuilder.Current.SetControllerFactory(new StructureMapControllerFactory());
        }
    }
}
