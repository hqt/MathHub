using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Core.Interfaces.MainPosts
{
    public interface IMainPostCommandService
    {
        /// <summary>
        /// Insert
        /// </summary>
        bool AddComment(int postId, Comment comment);
        bool AddReply(int postId, Reply reply);
        bool AddTag(int postId, string name);
        bool AddListTag(int problemId, List<String> name);

        /// <summary>
        /// Update
        /// </summary>
        bool UpdateComment(Comment comment);
        bool UpdateReply(Reply reply);

        /// <summary>
        /// Delete
        /// </summary>
        bool DeleteComment(Comment comment);
        bool DeleteTag(int postId, String tagName);
        bool DeleteReply(Reply reply);

       
    }
}
