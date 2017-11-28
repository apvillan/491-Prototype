using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Homework2.Models;
using Newtonsoft.Json.Linq;

namespace Homework2.Controllers
{
    public class GeographyController : ApiController
    {
        // GET: api/Geography
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Geography/5
        public object Get(int id)
        {
            Geography[] geoRequest = new Geography[2];
            Geography test = new Geography(1, "Long Beach", "city", 0, 0, null, null);
            geoRequest[0] = new Geography(1, "Long Beach", "city", 0, 0, null, null);
            geoRequest[1] = new Geography(2, "California", "state", 0, 0, geoRequest[0], null);

            //var geoResults = JArray.Parse(geoRequest);
            return new { results = geoRequest };
        }

        // POST: api/Geography 
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Geography/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Geography/5
        public void Delete(int id)
        {
        }
    }
}
