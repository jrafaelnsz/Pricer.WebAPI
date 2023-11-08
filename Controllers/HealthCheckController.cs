using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Pricer.WebAPI.Controllers
{
    public class HealthCheckController : ApiController
    {
        [HttpGet]
        [Route("api/HealthCheck/Health")]
        public string Health()
        {
            return "success";
        }

        [HttpPost]
        [Route("api/HealthCheck/CheckFilter")]
        public string CheckFilter([FromBody] Filter value)
        {
            if (value.MyProperty >0)
            {
                return "success";
            }

            return "error";
        }

        public class Filter
        {
            public int MyProperty { get; set; }
        }

        
    }
}