using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Core.Interfaces.Comments
{
    public interface ICommentCommandService
    {
        /// <summary>
        /// Insert
        /// </summary>
        bool AddCommentForReply(int replyId, Comment comment);
        bool AddCommentForPost(int postId, Comment comment);

        /// <summary>
        /// Update
        /// </summary>
        
    }
}
