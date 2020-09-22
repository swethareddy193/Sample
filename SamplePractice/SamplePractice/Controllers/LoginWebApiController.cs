using SamplePractice.BussinessLogic;
using SamplePractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SamplePractice.Controllers
{
    public class LoginWebApiController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Savedetails(PersonDetails obj)
        {
            DataAccessLayer da = new DataAccessLayer();
            var res = da.SaveData(obj);
            return Ok(res);
        }
        [HttpGet]
        public IHttpActionResult Get(int i)
        {
            return Ok(i);
        }
    }
}
