using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aspnetmvcapp.Controllers
{
    public class DBController : ApiController
    {
        [HttpGet]
        public string GetDB()
        {
            return Environment.GetEnvironmentVariable("FOO");
        }
    }
}
