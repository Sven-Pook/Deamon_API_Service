using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Deamon_API_Service.Controllers
{
    public class DateTimeController : ApiController
    {
        public DateTime Get()
        {
            return DateTime.Now;
        }
    }
}
