using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication.Interfaces;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class FiveBridgesController : ApiController
    {
        public ICountiesRepository Repository { get; private set; }

        public FiveBridgesController()
        {
        }

        public FiveBridgesController(ICountiesRepository repository)
        {
            this.Repository =  repository;
        }

        [System.Web.Mvc.Route("/api/GetCountyByName/{name}")]
        [System.Web.Mvc.HttpGet]
        public async Task<HttpResponseMessage> GetBridgeByName(string name)
        {
            if(Repository == null)
                Repository = new CountiesRepository();

            var county = await Repository.GetCountyByName(name);

            return county == null
                ? Request.CreateErrorResponse(HttpStatusCode.BadRequest, "we were unable to retrieve data for the county name specified.")
                : Request.CreateResponse(HttpStatusCode.OK, county.GetCountyInfo());
        }
    }


}