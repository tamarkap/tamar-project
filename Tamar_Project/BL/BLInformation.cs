using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BL
{
    public class BLInformation
    {
        public string member_id { get; set; }
        public Nullable<System.DateTime> t_positive_answer { get; set; }
        public Nullable<System.DateTime> recovery_date { get; set; }
        public Nullable<int> id_vaccination_1 { get; set; }
        public System.DateTime vaccination_date_1 { get; set; }
        public string vaccine_manufacturer_1 { get; set; }
        public Nullable<int> id_vaccination_2 { get; set; }
        public System.DateTime vaccination_date_2 { get; set; }
        public string vaccine_manufacturer_2 { get; set; }
        public Nullable<int> id_vaccination_3 { get; set; }
        public System.DateTime vaccination_date_3 { get; set; }
        public string vaccine_manufacturer_3 { get; set; }
        public Nullable<int> id_vaccination_4 { get; set; }
        public System.DateTime vaccination_date_4 { get; set; }
        public string vaccine_manufacturer_4 { get; set; }


    }
}
