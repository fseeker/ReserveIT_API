using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ReserveIT_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        public static string[] words = Array.Empty<string>();
        public static int pageSize;

        [HttpGet]
        public string[] Get()
        {
            return words;
        }

        [HttpPost]
        public IActionResult Post([FromBody] string[] words)
        {            
            Request.Headers.TryGetValue("page-size", out var pageSize);
            Int32.TryParse(pageSize, out int pSize);
            WeatherForecastController.words = words;
            WeatherForecastController.pageSize = pSize;


            return Created("","");
        }
    }
}
