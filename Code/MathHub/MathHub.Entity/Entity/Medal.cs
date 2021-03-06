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
    
    public partial class Medal
    {
        public Medal()
        {
            this.Rewards = new HashSet<Reward>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public MedalEnum Type { get; set; }
        public Nullable<int> TagId { get; set; }
        public int Maximum { get; set; }
    
        public virtual Tag Tag { get; set; }
        public virtual ICollection<Reward> Rewards { get; set; }
    }
}
