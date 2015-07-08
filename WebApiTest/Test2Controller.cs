using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiTest
{
    [UseJsonFormatter]
    public class Test2Controller : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return TestController.DATA;
        }
    }
}