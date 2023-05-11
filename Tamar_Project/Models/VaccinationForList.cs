using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VaccinationForList
    {
        public string member_id { get; set; }
        public int id_vaccination { get; set; }
        public System.DateTime vaccination_date{ get; set; }
        public string vaccine_manufacturer { get; set; }
    }
}
