//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MathHub.Entity.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Problem : MainPost
    {
        public Problem()
        {
            this.BlogProblems = new HashSet<BlogProblem>();
            this.DiscusstionProblems = new HashSet<DiscusstionProblem>();
            this.Invitations = new HashSet<Invitation>();
        }
    
    
        public virtual ICollection<BlogProblem> BlogProblems { get; set; }
        public virtual ICollection<DiscusstionProblem> DiscusstionProblems { get; set; }
        public virtual ICollection<Invitation> Invitations { get; set; }
    }
}