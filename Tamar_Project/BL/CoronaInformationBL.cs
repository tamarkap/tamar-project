using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;


namespace BL
{
    public class CoronaInformationBL
    {
        CoronaInformationDal coronaInformationDal = new CoronaInformationDal();
        public void Add(Corona_information corona_Information)
        {
            if (corona_Information.member_id.Length != 9)
            {
                throw new Exception("Id is Invalid");
            }
            foreach (var item in corona_Information.member_id)
            {
                if (item < 30 || item > 39)
                {
                    throw new Exception("Contains an invalid character");
                }
            }
            if (corona_Information.t_positive_answer > DateTime.Today || corona_Information.recovery_date<DateTime.Today)
            {
                throw new Exception("Invalid date");
            }
            coronaInformationDal.Add(corona_Information);   
        }

        public Corona_information GetCoronaInformationByMemberId(string memberId)
        {

            if (memberId.Length !=9)
            {
                throw new Exception("Id is Invalid");
            }
            foreach (var item in memberId)
            {
                if(item<30 || item >39)
                {
                    throw new Exception("Contains an invalid character");
                }
            }
            return GetCoronaInformationByMemberId(memberId);
        }

    }
}
