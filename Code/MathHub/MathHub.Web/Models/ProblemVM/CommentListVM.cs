using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MathHub.Web.Models.ProblemVM
{
    public class CommentListVM
    {
        public ICollection<CommentItemVM> CommentItemVms { get; set; }
    }
}