using MathHub.Core.Interfaces.MainPosts;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Core.Interfaces.Discussions
{
    public interface IDiscussionQueryService : IMainPostQueryService
    {
        /// <summary>
        /// Discussion
        /// </summary>
        IEnumerable<Discussion> GetNewestDiscussions(int offSet, int limit);
        Discussion GetDiscussionById(int id);
        IEnumerable<Discussion> GetDiscussionssByUserId(int userId, int limit);
    }
}
