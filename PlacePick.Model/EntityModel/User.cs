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
    
    public partial class User
    {
        public User()
        {
            this.Votes = new HashSet<Vote>();
            this.Routes = new HashSet<Route>();
        }
    
        public int id { get; set; }
        public string AspNetUserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
        public virtual ICollection<Route> Routes { get; set; }
    }
}
