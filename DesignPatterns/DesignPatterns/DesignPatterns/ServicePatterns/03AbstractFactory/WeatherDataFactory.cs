using System.Collections.Generic;

namespace DesignPatterns.ServicePatterns._03AbstractFactory
{
    public class WeatherDataFactory : IGlobalWeatherDataProvider, ILocalWeatherDataProvider
    {


        List<WeatherForecast> IGlobalWeatherDataProvider.GetGlobalWeatherData()
        {
            return new List<WeatherForecast>();
        }

        List<WeatherForecast> ILocalWeatherDataProvider.GetLocalWeatherData()
        {
            return new List<WeatherForecast>();
        }
    }
}
