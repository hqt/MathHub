using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MathHub.Web.Models.ProblemVM
{
    public class CreateProblemVM
    {
        [Display(Name = "Title:")]
        [Required(ErrorMessage="Title should not be empty")]
        public String Title { get; set; }
        
        [Display(Name = "Question Content:")]
        [Required(ErrorMessage = "Content should not be empty")]
        public String Content { get; set; }

        [Display(Name = "Tags")]
        [Required(ErrorMessage = "Tag should not be empty")]
        public String Tag { get; set; }
    }
}