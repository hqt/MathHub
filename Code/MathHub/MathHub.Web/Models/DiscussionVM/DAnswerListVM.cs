using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MathHub.Web.Models.DiscussionVM
{
    public class DAnswerListVM
    {
        [Required(ErrorMessage = "Answer cannot be empty.")]
        [Display(Name = "Add your answer")]
        public String NewAnswer { get; set; }
        public ICollection<DAnswerItemVM> AnswerItemVms { get; set; } 
    }
}