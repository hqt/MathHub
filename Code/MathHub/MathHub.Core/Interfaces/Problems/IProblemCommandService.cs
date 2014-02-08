using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathHub.Entity.Entity;

namespace MathHub.Core.Interfaces.Problems
{
    public interface IProblemCommandService
    {
        /// <summary>
        /// Insert Dal
        /// </summary>
        Problem AddProblem(Problem problem);
        Problem AddCommentForProblem(int problemId, Comment comment);
        Problem AddReplyForProblem(int problemId, Reply reply);

        /// <summary>
        /// Update Dal
        /// </summary>
        Boolean    UpdateProblem(Problem problem);
        Boolean    UpdateComment(Comment comment);
        Boolean    UpdateReply(Reply reply);

        /// <summary>
        /// Delete Dal
        /// </summary>
        Boolean DeleteCommentOfProblem(int problemId, Comment comment);
        Boolean DeleteProblem(Problem problem);
    }
}
