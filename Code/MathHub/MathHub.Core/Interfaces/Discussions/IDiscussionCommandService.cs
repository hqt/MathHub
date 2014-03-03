using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Core.Interfaces.Discussions
{
    public interface IDiscussionCommandService
    {
        /// <summary>
        /// Insert 
        /// </summary>
        bool AddDiscussion(Discussion discussion);


        /// <summary>
        /// Update
        /// </summary>
        bool UpdateDiscusion(Discussion discussion);


        /// <summary>
        /// Delete
        /// </summary>
        bool DeleteDiscussion(Discussion discussion);
    }
}
