using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class VaccinationDAL
    {
        Entities DB = new Entities();
        public int Add(Vaccination vaccination)
        {
            DB.Vaccinations.Add(vaccination);
            DB.SaveChanges();
            return vaccination.Id;
        }
        public List<Vaccination> GetAllVaccination()
        {
            var Vaccination = from i in DB.Vaccinations 
                              select i;
            Vaccination.ToList<Vaccination>();
            List <Vaccination> lst = new List <Vaccination>();
            foreach (var item in Vaccination)
            {
                Vaccination v = new Vaccination();
                v = item;
                lst.Add(v);
            }
            return lst;
        }
    }
}
