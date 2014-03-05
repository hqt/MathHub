using MathHub.Web.Models.CommonVM;
using MathHub.Web.Models.ProblemVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MathHub.Web.Models.DiscussionVM
{
    public class DetailDiscussionVM
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateModified { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }

        public Tuple<int, int> PostVote { get; set; }
        public Tuple<int, int, int> PostSocial { get; set; }
        public Tuple<int, int, int> PostReply { get; set; }       

        //public CommentListVM Comments { get; set; }
        public DCommentPostVM CommentPostVm { get; set; }
        public UserInfoVM UserInfo { get; set; }
    }
}