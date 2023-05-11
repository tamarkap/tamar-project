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
        CoronaInformationBL coronaInformationBL = new CoronaInformationBL();

        [HttpGet]
        [Route("getCoronaInformation")]
        public HttpResponseMessage GetCoronaInformation(string id)
        {
            try
            {
                var CoronaInformation = coronaInformationBL.GetCoronaInformationByMemberId(id);
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
                coronaInformationBL.Add(c);
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                return response;
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e);
            }
        }

        [HttpGet]
        [Route("GetnotVaccinated")]
        public HttpResponseMessage GetnotVaccinated()
        {
            try
            {
                int amount = coronaInformationBL.notVaccinatedBl();
                return Request.CreateResponse(HttpStatusCode.OK, amount);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e);
            }

        }

        [HttpGet]
        [Route("GetActivePatients")]
        public HttpResponseMessage GetActivePatients()
        {
            try
            {
                Dictionary<DateTime, int> myDictionary = coronaInformationBL.ActivePatientsBl();
                return Request.CreateResponse(HttpStatusCode.OK, myDictionary);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e);
            }

        }
    }
}