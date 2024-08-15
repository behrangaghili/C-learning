using DesignPatterns.Services.factory;
using DesignPatterns.Services.singletone;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System;
using DesignPatterns.ServicePatterns._04Builder;

namespace DesignPatterns.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        // 01Singleton
        [HttpGet("LogMessage")]
        public IActionResult LogMessage([FromQuery] string message)
        {
            // Using Singleton logger instance
            LoggerService.Instance.LogMessage(message);
            return Ok($"Logged: {message}");
        }

        // 02Factory
        [HttpGet("WeatherForecastFactory")]
        public IEnumerable<WeatherForecast> GetWeatherForecast([FromQuery] string providerType)
        {
            var factory = new WeatherProviderFactory();
            var provider = factory.CreateWeatherProvider(providerType ?? "Mock");
            return provider.GetWeatherForecast();
        }
        // 04Builder
        [HttpGet("WeatherForecastBuilder")]
        public IActionResult GetWeatherData([FromQuery] DateTime date, [FromQuery] int temperatureC, [FromQuery] string summary)
        {
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                // Using Builder pattern to create an instance of WeatherData
                var weatherData = new WeatherData.Builder()
                                    .WithDate(date == DateTime.MinValue ? DateTime.Now : date)  // Defaulting to DateTime.Now if not provided
                                    .WithTemperature(temperatureC)
                                    .WithSummary(string.IsNullOrWhiteSpace(summary) ? "Sunny" : summary)  // Defaulting to "Sunny" if not provided
                                    .Build();
                _logger.LogInformation( "factory pattern is called. date is {0}", date.ToString());
                // Returning the created WeatherData object as JSON
                return Ok(weatherData);
            }
            catch (Exception e)
            {
                // Logging the exception (consider using a logging framework like log4net or Serilog)
                // Logging mechanism might use Singleton Pattern to ensure single instance of logger is utilized.

                // Returning a generic error message, avoiding revealing sensitive information
                return StatusCode(500, "An error occurred while processing your request.");
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
    }
}

