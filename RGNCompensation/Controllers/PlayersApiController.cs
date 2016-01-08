using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RGNCompensation.Repository;
using RGNCompensation.Models;
using System.Web.Http.Description;

namespace RGNCompensation.Controllers
{
    public class PlayersApiController : ApiController
    {
        private PlayerRepo db = new PlayerRepo();
       
        // GET api/MembersApi
        [ResponseType(typeof(IEnumerable<Player>))]
        public IHttpActionResult Get()
        {
            return Ok(db.GetAllPlayers());
        }

        public IHttpActionResult Post([FromBody] Player item)
        {
            db.Update(item);
            db.SaveChanges();
            return Ok();
        }
        // POST api/Players
        [HttpPost]
        public IHttpActionResult Post([FromBody] PlayerCompensation item)
        {
            db.Update(item.Player, item.CompensationLog);
            db.SaveChanges();
            return Ok();            
        }

        // POST api/Players       

        // PUT api/PlayersApi/5
        [HttpPut]
        public IHttpActionResult Put([FromBody] Player item)
        {
            db.Update(item);
            db.SaveChanges();
            return Ok(item);
        }
    }




}
