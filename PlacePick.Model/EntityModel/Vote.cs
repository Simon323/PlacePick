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
    
    public partial class Vote
    {
        public int RouteId { get; set; }
        public int UserId { get; set; }
        public int Rate { get; set; }
    
        public virtual Route Route { get; set; }
        public virtual User User { get; set; }
    }
}
