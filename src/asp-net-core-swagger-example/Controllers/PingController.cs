using System;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_core_swagger_example.Controllers
{
    [Route("api/[controller]")]
    public class PingController
    {
        /// <summary>
        /// Returns the current date and time in UTC.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public DateTime Get()
        {
            return DateTime.UtcNow;
        }
    }
}
