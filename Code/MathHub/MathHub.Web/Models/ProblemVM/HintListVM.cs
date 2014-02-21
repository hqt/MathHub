using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MathHub.Web.Models.ProblemVM
{
    public class HintListVM
    {
        [Required(ErrorMessage = "Hint cannot be empty.")]
        [Display(Name = "Add your hint")]
        public String NewHint { get; set; }
        public ICollection<HintItemVM> HintItemVms { get; set; }
    }
}