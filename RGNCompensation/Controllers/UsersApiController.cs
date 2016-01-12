using RGNCompensation.Models;
using RGNCompensation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace RGNCompensation.Controllers
{
    public class UsersApiController : ApiController
    {
        private UsersRepo db = new UsersRepo();
        // GET api/UsersApi
        [ResponseType(typeof(IEnumerable<User>))]
        public IHttpActionResult Get()
        {
            return Ok(db.GetAllUsers());
        }
    }
}
