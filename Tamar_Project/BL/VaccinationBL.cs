using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BL
{
    public class VaccinationBL
    {
        CoronaInformationDal CoronaInformationDal=new CoronaInformationDal();   
        VaccinationDAL VaccinationDAL = new VaccinationDAL();
        public void Add(Vaccination vaccination, string id)
        {
            if (id.Length != 9)
            {
                throw new Exception("Id is Invalid");
            }
            foreach (var item in id)
            {
                if (item < 48 || item > 57)
                {
                    throw new Exception("Contains an invalid character");
                }
            }
            if (vaccination.vaccination_date > DateTime.Today )
            {
                throw new Exception("Invalid date");
            }
            Corona_information corona_Information = new Corona_information();
           corona_Information = CoronaInformationDal.GetCoronaInformationByMemberId(id);
            if (corona_Information.id_vaccination_4 == null ) 
            {
                return; 
            }
            int Vid=  VaccinationDAL.Add(vaccination);
            CoronaInformationDal.PutVaccination(Vid, id);

        }
        public List<Vaccination> GetAllVaccination()
        {
            return VaccinationDAL.GetAllVaccination();
        }
    }
}

