using System.Collections.Generic;

namespace DesignPatterns.ServicePatterns._03AbstractFactory
{
    public interface IGlobalWeatherDataProvider
    {
       public abstract List<WeatherForecast> GetGlobalWeatherData();
    }
}
