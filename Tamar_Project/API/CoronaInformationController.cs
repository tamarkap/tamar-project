using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http;
using System.Net;
using BL;
using Models;

namespace API
{
    
    public class CoronaInformationController: ApiController
    {
        private readonly CoronaInformationBL CoronaInformationBL;
        CoronaInformationBL coronaInformationBL = new CoronaInformationBL();

        [HttpGet]
        [Route("getCoronaInformation")]
        public HttpResponseMessage GetCoronaInformation(string id)
        {
            try
            {
                var CoronaInformation = CoronaInformationBL.GetCoronaInformationByMemberId(id);
                return Request.CreateResponse(HttpStatusCode.OK, CoronaInformation);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e);
            }
        }

        [HttpPost]
        [Route("PostCoronaInformation")]
        public HttpResponseMessage PostCoronaInformation(Corona_information c)
        {
            try
            {
                CoronaInformationBL.Add(c);
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