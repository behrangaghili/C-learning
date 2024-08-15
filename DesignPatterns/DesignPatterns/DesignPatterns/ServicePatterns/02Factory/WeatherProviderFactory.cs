namespace DesignPatterns.Services.factory
{
    public class WeatherProviderFactory
    {
        public IWeatherProvider CreateWeatherProvider(string type)
        {
            switch (type)
            {
                case "Mock":
                    return new MockWeatherProvider();
                case "Real":
                    return new RealWeatherProvider();
                default:
                    throw new NotSupportedException($"WeatherProvider of type {type} is not supported");
            }
        }
    }

}
