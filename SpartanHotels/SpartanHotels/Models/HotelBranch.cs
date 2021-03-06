//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpartanHotels.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HotelBranch
    {
        public HotelBranch()
        {
            this.HotelPartners = new HashSet<HotelPartner>();
            this.RoomTypes = new HashSet<RoomType>();
        }
    
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    
        public virtual ICollection<HotelPartner> HotelPartners { get; set; }
        public virtual ICollection<RoomType> RoomTypes { get; set; }
    }
}
