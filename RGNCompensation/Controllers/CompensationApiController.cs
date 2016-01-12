using RGNCompensation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RGNCompensation.Controllers
{
    public class CompensationApiController : ApiController
    {
        private CompensationRepo db = new CompensationRepo();
        public IHttpActionResult Get()
        {
            return Ok(db.GetAllCompensationLogs());
        }
    }
}
