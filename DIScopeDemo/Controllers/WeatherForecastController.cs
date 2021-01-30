using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIScopeDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DIScopeDemo.Controllers
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
        private readonly AlphaService _alphaService;
        private readonly BetaService _betaService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, AlphaService alphaService, BetaService betaService)
        {
            _logger = logger;
            _alphaService = alphaService;
            _betaService = betaService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            _alphaService.LogRequestId();
            _betaService.LogRequestId();
            return null;
        }
    }
}
