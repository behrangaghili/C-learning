# DesignPatternApiApp

    MyWebApiApp is a .NET Web API project that demonstrates the utilization of various design patterns in a practical application context.

## Getting Started

    This Web API application is developed using .NET 6.0. To get started, clone the repository and navigate to the project folder. 
    Use the following command to run the project:

    ```shell
    dotnet run




# Design Patterns Implemented
## 1. Singleton Pattern
Explanation

The Singleton Pattern is used to ensure a class has only one instance and provides a global point to access it. It's typically used for logging services, driver objects, caching, thread pools, or database connections.
Implementation in MyWebApiApp

In this project, the Singleton pattern is implemented in the LoggerService class, which provides a method to log messages. The pattern ensures that only one instance of the logger service exists in the application.
Key Components

    _instance: A static variable to hold the single instance of the class.
    _lock: A static object to lock on, for thread safety during instance creation.
    Instance: A public static property that returns the single instance of the class, creating it if necessary.
    LogMessage(string message): A method to log messages to a designated output.

Usage

In the WeatherForecastController, the LoggerService is used to log a message each time a GET request is made to the API:

### 2. Factory Pattern

#### Explanation
The Factory Method Pattern provides an interface for creating objects in a superclass but allows subclasses to alter the type of objects that will be created. It is useful for implementing a "family" of objects that share common characteristics and functionality.

#### Implementation in MyWebApiApp

In this project, the Factory Pattern is implemented through the `WeatherProviderFactory` class, which creates instances of different `IWeatherProvider` implementations.

##### Key Components

- **IWeatherProvider**: An interface defining the contract for weather providers.
- **MockWeatherProvider** and **RealWeatherProvider**: Classes that implement `IWeatherProvider`, providing different weather data fetching strategies.
- **WeatherProviderFactory**: The factory class that decides which type of weather provider to instantiate based on provided input.

##### Usage

In the `WeatherForecastController`, the `WeatherProviderFactory` is used to instantiate a weather provider based on a query parameter:
 
### 3. Abstract Factory Pattern

#### Explanation
The Abstract Factory Pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes. This pattern is particularly useful when the system needs to be independent of how its objects are created, composed, and represented, and the system is configured with multiple families of objects.

#### Implementation in MyWebApiApp

In our context, the Abstract Factory Pattern is implemented to manage the creation of weather data providers, categorized into two - `Local` and `Global`, and each having two variations - `Mock` and `Real`.

##### Key Components

- **IWeatherDataProviderFactory**: An interface declaring methods for creating objects in the family of weather data providers.
- **ILocalWeatherDataProvider** and **IGlobalWeatherDataProvider**: Interfaces defining contracts for local and global weather data providers respectively.
- **MockWeatherDataProviderFactory** and **RealWeatherDataProviderFactory**: Concrete factories implementing `IWeatherDataProviderFactory` to create respective variants of `ILocalWeatherDataProvider` and `IGlobalWeatherDataProvider`.

##### Usage

    ```csharp
    public WeatherForecastController : ControllerBase
    {
        private readonly IWeatherDataProviderFactory _weatherDataProviderFactory;

        public WeatherForecastController(IWeatherDataProviderFactory weatherDataProviderFactory)
        {
            _weatherDataProviderFactory = weatherDataProviderFactory;
        }

        [HttpGet("local")]
        public WeatherData GetLocalWeather()
        {
            var localWeatherProvider = _weatherDataProviderFactory.CreateLocalWeatherDataProvider();
            return localWeatherProvider.GetLocalWeatherData();
        }

        [HttpGet("global")]
        public WeatherData GetGlobalWeather()
        {
            var globalWeatherProvider = _weatherDataProviderFactory.CreateGlobalWeatherDataProvider();
            return globalWeatherProvider.GetGlobalWeatherData();
        }
    }

### 4. Builder Pattern

#### Explanation
The Builder Pattern is used to construct a complex object step by step. It's especially useful when an object needs to be created with numerous possible configurations. The Builder pattern provides clear separation and a unique layer for testing the construction of objects. It also enhances the readability of object creation when there are many parameters, some of which have defaults.

#### Implementation in MyWebApiApp

In the context of our weather forecast application, the Builder Pattern is employed to facilitate the construction of `WeatherData` objects.

##### Key Components

- **WeatherData**: The main class, which we are aiming to build instances of. This class contains properties like `Date`, `TemperatureC`, and `Summary`.
- **Builder**: A nested class within `WeatherData` which facilitates its construction. It provides methods for setting the properties of `WeatherData`, as well as a `Build` method, which creates an instance of `WeatherData` with the specified configurations.

##### Usage

    ```csharp
    var weatherData = new WeatherData.Builder()
                        .WithDate(DateTime.UtcNow)
                        .WithTemperature(23)
                        .WithSummary("Partly Cloudy")
                        .Build();
