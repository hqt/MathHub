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
    
    public partial class Tag
    {
        public Tag()
        {
            this.FavoriteTags = new HashSet<FavoriteTag>();
            this.ProblemTags = new HashSet<PostTag>();
            this.Medals = new HashSet<Medal>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> CreatorId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateModified { get; set; }
    
        public virtual User Creator { get; set; }
        public virtual ICollection<FavoriteTag> FavoriteTags { get; set; }
        public virtual ICollection<PostTag> ProblemTags { get; set; }
        public virtual ICollection<Medal> Medals { get; set; }
        public virtual Image Image { get; set; }
    }
}
