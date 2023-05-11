using BL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Net;

namespace API
{
    
    public class MemberController : ApiController
    {
        private readonly MemberBL memberBL;
        MemberBL MemberBL = new MemberBL();

        [HttpGet]
        [Route("getAllMembers")]
        public HttpResponseMessage GetMembers()
        {
          var allMembers = MemberBL.GetAllMembers();
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [HttpGet]
        [Route("getMember")]
        public HttpResponseMessage GetMember(string id)
        {
            try
            {
                var member = MemberBL.GetMember(id);
                return Request.CreateResponse(HttpStatusCode.OK, member);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e);
            }

        }
        [HttpPost]
        [Route("PostMember")]
        public HttpResponseMessage PostMember(Member member) 
        {
            try
            {
                memberBL.Add(member);
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                return response;
            }
            catch (Exception e)
            {
               return Request.CreateResponse(HttpStatusCode.BadRequest, e);
            }
            
        }
    }
}