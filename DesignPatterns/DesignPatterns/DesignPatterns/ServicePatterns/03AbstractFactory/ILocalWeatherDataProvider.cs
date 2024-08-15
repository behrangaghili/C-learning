namespace DesignPatterns.ServicePatterns._03AbstractFactory
{
    public interface ILocalWeatherDataProvider
    {
        public abstract List<WeatherForecast> GetLocalWeatherData();
    }
}
