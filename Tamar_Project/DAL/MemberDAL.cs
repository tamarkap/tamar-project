using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class MemberDAL
    
    {
        HMO_DBEntities DB = new HMO_DBEntities();
        
        public void Add(Member member)
        {
            member.Corona_information = new Corona_information();
            member.Corona_information.member_id = member.Id;

            DB.Members.Add(member);
            DB.SaveChanges();
        }
        public Member GetMember(string id)
        {
            
            var member = from i in DB.Members
                            where i.Id == id
                            select i;

            Member member2 = new Member();
            member.ToList<Member>();
            member2 = member.FirstOrDefault();
            return member2;
        }
        public List<Member> GetAllMembers()
        {
            if (DB.Members.ToList() == null)
                return null;
        else return DB.Members.ToList();
        }
      

    }
}
