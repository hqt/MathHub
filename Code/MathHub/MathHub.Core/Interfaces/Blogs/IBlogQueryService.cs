using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Core.Interfaces.Blogs
{
    public interface IBlogQueryService
    {
        IEnumerable<Blog> GetAllBlogs(int offset, int limit);
        Blog GetBlogById(int blogId);
        IEnumerable<Blog> GetAllBlogsByUserId(int userId, int offset, int limit);
        IEnumerable<Blog> GetNewBlogs(int limit);
    }
}
