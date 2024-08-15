namespace DesignPatterns.ServicePatterns._03AbstractFactory
{
    public interface IWeatherDataProviderFactory
    {
        ILocalWeatherDataProvider CreateLocalWeatherDataProvider();
        IGlobalWeatherDataProvider CreateGlobalWeatherDataProvider();
    }

}
