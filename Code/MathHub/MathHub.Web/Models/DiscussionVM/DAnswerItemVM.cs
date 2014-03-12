using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MathHub.Web.Models.DiscussionVM
{
    public class DAnswerItemVM
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateModified { get; set; }
        public int UserId { get; set; }
        public string UserUsername { get; set; }

        public int VoteUpNum { get; set; }
        public int VoteDownNum { get; set; }
        public int ReportNum { get; set; }
        public int CommentNum { get; set; }
    }
}