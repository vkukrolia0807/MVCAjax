using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Api.Controllers
{
    [EnableCors(methods:"*",origins:"*",headers:"*")]
    public class WebApiController : ApiController
    {

    }
}
