using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MathHub.Web.Models.ProblemVM
{
    public class HintPostVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Hint cannot be empty.")]
        [Display(Name = "Add your Hint")]
        public string Content { get; set; }

        public Nullable<int> MainPostId { get; set; }
    }
}