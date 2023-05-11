using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BL
{
    public class MemberBL
    {
        MemberDAL MemberDAL = new MemberDAL();
        public void Add(Member member)
        {
            if (member.Id.Length != 9)
            {
                throw new Exception("Id is Invalid");
            }
            foreach (var item in member.Id)
            {
                if (item < 30 || item > 39)
                {
                    throw new Exception("Contains an invalid character");
                }
            }
            if (member.date_of_birth > DateTime.Today)
            {
                throw new Exception("Invalid date");
            }
            MemberDAL.Add(member);
        }

        public Member GetMember(string id)
        {
            if (id.Length != 9)
            {
                throw new Exception("Id is Invalid");
            }
            foreach (var item in id)
            {
                if (item < 30 || item > 39)
                {
                    throw new Exception("Contains an invalid character");
                }
            }
            return MemberDAL.GetMember(id); 
        }
        public List<Member> GetAllMembers()
        {
           return MemberDAL.GetAllMembers();
        }
    }
}
