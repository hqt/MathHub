using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MathHub.Web.Models.DiscussionVM
{
    public class DCommentListVM
    {
        public ICollection<DCommentItemVM> CommentItemVms { get; set; }
    }
}