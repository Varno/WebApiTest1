using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiTest
{
    [UseXmlFormatter]
    public class TestController : ApiController
    {
        public static IEnumerable<string> DATA = Enumerable.Range(1, 10)
            .Select(i => string.Format("Value {0}", i))
            .ToList();
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return DATA;
        }
    }
}