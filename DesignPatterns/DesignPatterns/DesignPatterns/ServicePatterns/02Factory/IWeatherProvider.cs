namespace DesignPatterns.Services.factory
{
    public interface IWeatherProvider
    {
        IEnumerable<WeatherForecast> GetWeatherForecast();
    }

}
