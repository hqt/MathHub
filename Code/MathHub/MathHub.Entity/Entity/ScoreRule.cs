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
    
    public partial class ScoreRule
    {
        public int Id { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int ProblemUpvote { get; set; }
        public int ProblemDownvote { get; set; }
        public int DefaultUpvote { get; set; }
        public int DefaultDownvote { get; set; }
    }
}
