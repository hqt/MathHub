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
    
    public partial class Attendance
    {
        public Attendance()
        {
            this.Messages = new HashSet<Message>();
        }
    
        public int Id { get; set; }
        public System.DateTime DateJoined { get; set; }
        public int UserId { get; set; }
        public int ConversationId { get; set; }
        public Nullable<System.DateTime> DateSeen { get; set; }
    
        public virtual User User { get; set; }
        public virtual Conversation Conversation { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
