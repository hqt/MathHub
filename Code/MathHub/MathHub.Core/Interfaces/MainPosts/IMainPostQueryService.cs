using MathHub.Core.Interfaces.Posts;
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
    public interface IMainPostQueryService : IPostQueryService
    {
        /// <summary>
        /// Tag
        /// </summary>
        List<Tag> GetAllPostTag(int postId);
        List<String> GetAllPostTagName(int postId);

        /// <summary>
        /// Reply
        /// </summary>
        IEnumerable<Reply> GetAllReplies(int mainPostId, ReplyEnum type, int offset, int limit);

        /// <summary>
        /// statistic : count all fields
        /// </summary>

        /** favorite - report - share */
        Tuple<int, int, int> GetPostSocialReport(int mainPostId);
        int CountFavorite(int mainPostId);
        /** comment - answer - hint */
        Tuple<int, int, int> GetPostReplyReport(int mainPostId);
    }
}
