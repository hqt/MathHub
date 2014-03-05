using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MathHub.Web.Models.DiscussionVM
{
    public class CommentPostVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Comment cannot be empty.")]
        [Display(Name = "Add your comment")]
        public string Content { get; set; }

        public Nullable<int> ReplyId { get; set; }
        public Nullable<int> MainPostId { get; set; }

        public string Type { get; set; }
    }
}