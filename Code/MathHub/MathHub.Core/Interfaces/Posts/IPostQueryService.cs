using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Core.Interfaces.Posts
{
    /// <summary>
    /// generic interface
    /// this interface will be inherited by all post interface
    /// </summary>
    public interface IPostQueryService
    {
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
        /// statistic : count all fields
        /// </summary>
        int CountReplyComment(int postId);
        int CountQuestionComment(int postId);
        int CountReport(int postId);
    }
}