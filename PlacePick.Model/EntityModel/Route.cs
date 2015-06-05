//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlacePick.Model.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Route
    {
        public Route()
        {
            this.Points = new HashSet<Point>();
            this.Votes = new HashSet<Vote>();
            this.Tags = new HashSet<Tag>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public System.DateTime Duration { get; set; }
        public string City { get; set; }
        public Nullable<int> CreatorId { get; set; }
        public string KML { get; set; }
    
        public virtual ICollection<Point> Points { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual User User { get; set; }
    }
}
