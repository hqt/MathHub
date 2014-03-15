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
        /// <summary>
        /// Tag
        /// </summary>
        List<Tag> GetAllPostTag(int postId);
        List<String> GetAllPostTagName(int postId);

        /// <summary>
        /// Comment
        /// </summary>
        IEnumerable<Comment> GetAllReplyComments(int replyId, int offset, int limit);
        IEnumerable<Comment> GetAllMainPostComments(int mainPostId, int offset, int limit);

        /// <summary>
        /// Vote
        /// </summary>
        int GetPostVoteUp(int postId);
        int GetPostVoteDown(int postId);
        Tuple<int, int> GetPostVote(int postId);

        /// <summary>
        /// Reply
        /// </summary>
        IEnumerable<Reply> GetAllReplies(int mainPostId, ReplyEnum type, int offset, int limit);

        /// <summary>
        /// statistic : count all fields
        /// </summary>

        /** favorite - report - share */
        Tuple<int, int, int> GetPostSocialReport(int mainPostId);
        int GetFavoriteNum(int mainPostId);
        /** comment - answer - hint */
        Tuple<int, int, int> GetPostReplyReport(int mainPostId);
    }
}
