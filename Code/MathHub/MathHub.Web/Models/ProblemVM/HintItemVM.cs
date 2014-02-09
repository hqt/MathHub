using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MathHub.Web.Models.ProblemVM
{
    public class HintItemVM
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateModified { get; set; }
        public int UserId { get; set; }
        public int VoteUpNum { get; set; }
        public int VoteDownNum { get; set; }
        public int ReportNum { get; set; }
        public string UserUsername { get; set; }


        public ICollection<CommentItemVM> Comments { get; set; }
    }
}