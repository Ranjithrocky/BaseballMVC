//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaseballMVC.DataService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venue()
        {
            this.Events = new HashSet<Event>();
        }
    
        public int venueId { get; set; }
        public string venueName { get; set; }
        public string venueImageUrl { get; set; }
        public string venueDescription { get; set; }
        public string venueLocation { get; set; }
    /*
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]*/
        public virtual ICollection<Event> Events { get; set; }
    }
}
