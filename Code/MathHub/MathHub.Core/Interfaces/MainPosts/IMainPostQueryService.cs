using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Core.Interfaces.MainPosts
{
    /// <summary>
    /// generic interface
    /// this interface will be inherited by Problem/Blog/Discussion interface
    /// </summary>
    public interface IMainPostQueryService
    {
        List<Tag> GetAllMainPostTag(int postId);
        List<String> GetAllMainPostTagName(int postId);
        /// <summary>
        /// Get all MainPost Detail.
        /// Include : ...
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        MainPost GetMainPostDetail(int postId);
    }
}
