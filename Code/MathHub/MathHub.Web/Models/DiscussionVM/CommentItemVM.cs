using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MathHub.Web.Models.DiscussionVM
{
    public class CommentItemVM
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateModified { get; set; }
        public int UserId { get; set; }
        public Nullable<int> ReplyId { get; set; }
        public Nullable<int> MainPostId { get; set; }

        public int VoteUpNum { get; set; }

        public string UserUsername { get; set; }
    }
}