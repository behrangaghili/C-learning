namespace DesignPatterns.Services.factory
{
    public class MockWeatherProvider : IWeatherProvider
    {
        public IEnumerable<WeatherForecast> GetWeatherForecast()
        {
            // Returning mocked data
            return new List<WeatherForecast>
        {
            new WeatherForecast { Date = DateTime.Now, TemperatureC = 25, Summary = "Mock Hot" },
             
        };
        }
    }

}
