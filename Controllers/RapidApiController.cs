using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SteamMarketAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RapidApiController : ControllerBase
    {
        private readonly ILogger<RapidApiController> _logger;

        public RapidApiController(ILogger<RapidApiController> logger)
        {
            _logger = logger;
        }






    }
}
