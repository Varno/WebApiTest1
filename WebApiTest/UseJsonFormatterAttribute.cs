using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http.Controllers;

namespace WebApiTest
{
    public class UseJsonFormatterAttribute : Attribute, IControllerConfiguration
    {
        public void Initialize(HttpControllerSettings settings,
            HttpControllerDescriptor descriptor)
        {
            // Clear the formatters list.
            settings.Formatters.Clear();

            // Add a custom media-type formatter.
            settings.Formatters.Add(new JsonMediaTypeFormatter());
        }
    }
}
