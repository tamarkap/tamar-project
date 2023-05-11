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
    public class VaccinationController : ApiController
    {
        VaccinationBL vaccinationBl =new VaccinationBL();

        [HttpGet]
        [Route("getVaccinations")]
        public HttpResponseMessage GetVaccinations()
        {
            List <Vaccination> lst = new List <Vaccination>();
            lst = vaccinationBl.GetAllVaccination();
            return Request.CreateResponse(HttpStatusCode.OK, lst);
        }

        [HttpPost]
        [Route("PostVaccinations")]
        public HttpResponseMessage PostMember(Vaccination vaccination, string id)
        {
            try
            {
                vaccinationBl.Add(vaccination, id);
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