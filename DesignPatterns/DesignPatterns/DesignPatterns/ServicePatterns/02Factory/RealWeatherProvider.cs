using DesignPatterns.ServicePatterns._03AbstractFactory;

namespace DesignPatterns.Services.factory
{
    public class RealWeatherProvider : IWeatherProvider 
    {
        public IEnumerable<WeatherForecast> GetWeatherForecast()
        {
            // Implementation to retrieve real weather data from an API or other source
            // For simplicity, returning mocked data here too
            return new List<WeatherForecast>
        {
            new WeatherForecast { Date = DateTime.Now, TemperatureC = 22, Summary = "Real Mild" },
       
        };
        }
    }

}
