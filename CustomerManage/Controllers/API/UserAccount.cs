using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomerManage.Controllers
{
    public class UserAccount : ApiController
    {
        // GET api/<controller>
        //[Route("api/v1/useraccount")]
        [HttpGet]
        public IEnumerable<Models.DB.UserAccount> Get()
        {
            Models.DB.UserAccount[] returnValue = null;

            using (Models.DB.FoKaContext fokaContext = new Models.DB.FoKaContext())
            {
                returnValue = fokaContext.UserAccount.ToArray();
            }

            return returnValue;
        }

        // GET api/<controller>/5
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}