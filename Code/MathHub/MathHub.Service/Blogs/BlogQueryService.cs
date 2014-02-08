using MathHub.Core.Infrastructure.Interfaces.Repository;
using MathHub.Core.Infrastructure.Repository;
using MathHub.Core.Interfaces.Blogs;
using MathHub.Core.Interfaces.MainPosts;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Service.Blogs
{
    public class BlogQueryService : IMainPostQueryService, IBlogQueryService
    {
        MathHubModelContainer ctx;
        IRepository<Blog> blogRepository;

        public BlogQueryService(
            IRepository<Blog> blogRepository,
            IMathHubDbContext context)
        {
            this.ctx = context.GetDbContext();
            this.blogRepository = blogRepository;
        }

        public List<Tag> GetAllMainPostTag(int postId)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllMainPostTagName(int postId)
        {
            throw new NotImplementedException();
        }

        public MainPost GetMainPostDetail(int postId)
        {
            throw new NotImplementedException();
        }
    }
}
