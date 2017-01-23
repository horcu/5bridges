﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Routing;
using WebApplication.Interfaces;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class FiveBridgesController : ApiController
    {
        private ICountiesRepository _repository;

        public FiveBridgesController()
        {
        }

        public FiveBridgesController(ICountiesRepository repository)
        {
            this._repository =  repository;
        }

        [System.Web.Mvc.Route("/api/GetCountyByName/{name}")]
        public async Task<HttpResponseMessage> GetBridgeByName(string name)
        {
            if(_repository == null)
                _repository = new CountiesRepository();

            var county = await _repository.GetCountyByName(name);

            return county == null
                ? Request.CreateErrorResponse(HttpStatusCode.BadRequest, "we were unable to retrieve data for the county name specified.")
                : Request.CreateResponse(HttpStatusCode.OK, county.GetCountyInfo());
        }
    }


}