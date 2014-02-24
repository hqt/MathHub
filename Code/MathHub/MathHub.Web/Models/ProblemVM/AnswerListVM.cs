using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MathHub.Web.Models.ProblemVM
{
    public class AnswerListVM
    {
        [Required(ErrorMessage = "Answer cannot be empty.")]
        [Display(Name = "Add your answer")]
        public String NewAnswer { get; set; }
        public ICollection<AnswerItemVM> AnswerItemVms { get; set; } 
    }
}