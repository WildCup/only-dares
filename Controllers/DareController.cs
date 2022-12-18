using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DaresGacha.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DareController : ControllerBase
    {
        private readonly ILogger<DareController> _logger;

        public DareController(ILogger<DareController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("xd lalala");
        }
    }
}