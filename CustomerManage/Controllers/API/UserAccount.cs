using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomerManage.Controllers.API
{
    public class UserAccountController : ApiController
    {
        // GET api/<controller>
        [Route("api/v1/useraccount")]
        public IEnumerable<Models.DB.UserAccount> Get()
        {
            List<Models.DB.UserAccount> returnValue = null;

            returnValue.Add(new Models.DB.UserAccount()
            {
                UserID = 12,
                UserCode = "weschen",
                UserName = "WesChen",
                Active = "Y"
            });

            //using (Models.DB.FoKaContext fokaContext = new Models.DB.FoKaContext())
            //{
            //    returnValue = fokaContext.UserAccount.ToArray();
            //}

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