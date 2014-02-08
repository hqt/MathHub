using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathHub.Web.Models.ProblemVM
{
   public class CommentItemVM
    {
       public CommentItemVM(string content, string username)
       {
           Content = content;
           UserUsername = username;
       }
        public int Id { get; set; }
        public string Content { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateModified { get; set; }
        public int UserId { get; set; }
        public int? ReplyId { get; set; }
        public int? MainPostId { get; set; }

        public string UserUsername { get; set; }
    }
}
