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
    
    public partial class ScorePermission
    {
        public ScorePermission()
        {
            this.Functions = new HashSet<Function>();
        }
    
        public int Id { get; set; }
        public int Score { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }
    
        public virtual ICollection<Function> Functions { get; set; }
    }
}