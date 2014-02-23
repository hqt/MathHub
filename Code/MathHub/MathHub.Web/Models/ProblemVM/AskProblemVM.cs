using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MathHub.Web.Models.ProblemVM
{
    /// <summary>
    /// ViewModel for problem when asking
    /// </summary>
    public class AskProblemVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Question Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Content is required")]
        public string Content { get; set; }
    }
}