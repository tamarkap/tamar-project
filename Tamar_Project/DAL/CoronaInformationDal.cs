using Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CoronaInformationDal
    {
        HMO_DBEntities DB = new HMO_DBEntities();
        public void Add(Corona_information corona_Information)
        {
            DB.Corona_information.Add(corona_Information);
            DB.SaveChanges();
        }
        public Corona_information GetCoronaInformationByMemberId(string memberId)
        {
            var Vaccination = from i in DB.Corona_information
                              where i.member_id == memberId
                              select i;
            Vaccination.ToList<Corona_information>();
            Corona_information corona_Information = new Corona_information();
            corona_Information = Vaccination.FirstOrDefault();
            return corona_Information;
        }
        //        
        //public List<Corona_information> GetAllCoronaInformations(string id)
        //{
        //    var Vaccination1 = from i in DB.Corona_information
        //                         join j in DB.Vaccinations on i.id_vaccination_3 equals j.Id
        //                          where i.member_id == id
        //                         select i;
        //    return DB.Corona_information.ToList();
        //}
        public void PutVaccination(int VId, string MemberId)
        {

        }




    }
}
