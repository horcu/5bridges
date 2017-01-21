using System;
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
        private IBridgesRepository _repository;

        public FiveBridgesController()
        {
        }

        public FiveBridgesController(IBridgesRepository repository)
        {
            this._repository =  repository;
        }

        [System.Web.Mvc.Route("/api/GetBridgeByName/{name}")]
        public async Task<HttpResponseMessage> GetBridgeByName(string name)
        {
            if(_repository == null)
                _repository = new BridgesRepository();

            var bridge = await _repository.GetBridgesByName(name);

            return  new HttpResponseMessage(HttpStatusCode.OK);
        }
    }


}