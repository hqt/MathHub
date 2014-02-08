using MathHub.Core.Infrastructure.Interfaces.Repository;
using MathHub.Core.Infrastructure.Repository;
using MathHub.Core.Interfaces.Blogs;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Service.Blogs
{
    public class BlogCommandService :IBlogCommandService
    {
        MathHubModelContainer ctx;
        IRepository<Blog> blogRepository;

        public BlogCommandService(
            IRepository<Blog> blogRepository,
            IMathHubDbContext context)
        {
            this.ctx = context.GetDbContext();
            this.blogRepository = blogRepository;
        }
            
    }
}
