using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OTRetailerWebApi.Controller
{
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("{controller}/Home")]
        public IHttpActionResult Home()
        {
            return Ok("Welcome to OTRetailer web api....");
        }
    }
}
