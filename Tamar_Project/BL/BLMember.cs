using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BL
{
    public class BLMember
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
    }
}
