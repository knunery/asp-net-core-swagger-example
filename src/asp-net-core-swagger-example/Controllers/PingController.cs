using System;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_core_swagger_example.Controllers
{
    [Route("api/[controller]")]
    public class PingController
    {
        [HttpGet]
        public object Get()
        {
            return DateTime.UtcNow;
        }
    }
}
