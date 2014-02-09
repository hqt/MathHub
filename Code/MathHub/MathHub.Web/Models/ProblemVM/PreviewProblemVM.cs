using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MathHub.Web.Models.CommonVM;

namespace MathHub.Web.Models.ProblemVM
{
    public class PreviewProblemVM
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateModified { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }

        public int FavoriteNum { get; set; }
        public int ReportNum { get; set; }
        public int ShareNum { get; set; }
        public int VoteUpNum { get; set; }
        public int VoteDownNum { get; set; }
        public int AnswerNum { get; set; }
        public int HintNum { get; set; }

        public UserInfoVM UserInfo { get; set; }
    }
}