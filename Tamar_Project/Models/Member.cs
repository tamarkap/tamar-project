//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        public string Id { get; set; }
        public string member_name { get; set; }
        public string member_last_name { get; set; }
        public string city_address { get; set; }
        public string street_address { get; set; }
        public long house_number { get; set; }
        public System.DateTime date_of_birth { get; set; }
        public long phone { get; set; }
        public long mobile_phone { get; set; }
        public byte[] image { get; set; }
    
        public virtual Corona_information Corona_information { get; set; }
    }
}
