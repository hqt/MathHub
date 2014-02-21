using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MathHub.Web.Models.ProblemVM
{
    public class CommentListVM
    {
        [Required(ErrorMessage = "Comment cannot be empty.")]
        [Display(Name = "Add your comment")]
        public String NewComment { get; set; }

        public ICollection<CommentItemVM> CommentItemVms { get; set; }
    }
}