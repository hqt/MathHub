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
    
    public partial class TopicEnrollment
    {
        public int Id { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int TopicId { get; set; }
        public int UserId { get; set; }
        public TopicPermissionEnum Type { get; set; }
        public System.DateTime DateSeen { get; set; }
    
        public virtual Topic Topic { get; set; }
        public virtual User User { get; set; }
    }
}
