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
    
    public partial class Event
    {
        public int eventId { get; set; }
        public string eventName { get; set; }
        public string applicantName { get; set; }
        public string applicantAddress { get; set; }
        public string applicantEmail { get; set; }
        public string applicantMobile { get; set; }
        public int eventAddress { get; set; }
        public System.DateTime eventFromdate { get; set; }
        public System.DateTime eventToDate { get; set; }
        public int RefreeId { get; set; }
        public string UserId { get; set; }
    
        public virtual Refree Refree { get; set; }
        public virtual User User { get; set; }
        public virtual Venue Venue { get; set; }
    }
}
