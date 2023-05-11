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
        private readonly VaccinationBL vaccinationBL;
        VaccinationBL vaccinationBl =new VaccinationBL();

        [HttpGet]
        [Route("getVaccinations")]
        public HttpResponseMessage GetVaccinations()
        {
            List <Vaccination> lst = new List <Vaccination>();
            lst = vaccinationBL.GetAllVaccination();
            return Request.CreateResponse(HttpStatusCode.OK, lst);
        }

        [HttpPost]
        [Route("PostVaccinations")]
        public HttpResponseMessage PostMember(Vaccination vaccination, string id)
        {
            try
            {
                vaccinationBL.Add(vaccination, id);
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