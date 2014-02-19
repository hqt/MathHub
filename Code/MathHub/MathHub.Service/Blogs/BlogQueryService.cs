using MathHub.Core.Infrastructure.Interfaces.Repository;
using MathHub.Core.Infrastructure.Repository;
using MathHub.Core.Interfaces.Blogs;
using MathHub.Core.Interfaces.MainPosts;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace MathHub.Service.Blogs
{
    public class BlogQueryService : IBlogQueryService
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

        public IEnumerable<Blog> GetAllBlogs(int offset, int limit)
        {
            return ctx.Posts.OfType<Blog>().OrderBy(b => b.Id).Skip(offset).Take(limit);
        }

        public Blog GetBlogById(int blogId)
        {
            return ctx.Posts.OfType<Blog>().FirstOrDefault(b => b.Id == blogId);
        }

        public IEnumerable<Blog> GetAllBlogsByUserId(int userId)
        {
            return ctx.Posts.OfType<Blog>().Where(b => b.UserId == userId);
        }

        public IEnumerable<Blog> GetNewBlogs(int limit)
        {
            return ctx.Posts.OfType<Blog>().OrderByDescending(b => b.DateCreated).Take(limit);
        }
    }
}
