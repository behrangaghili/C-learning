
 
namespace DesignPatterns.Services.singletone
{
    public class LoggerService
    {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        private static LoggerService _instance = null;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

        private static readonly object _lock = new object();

        // Summary:
        //     Private constructor ensures that the object is not instantiated from outside the class.
        private LoggerService() { }

        // Summary:
        //     Gets the single instance of LoggerService, creating it if necessary in a thread-safe manner.
        public static LoggerService Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new LoggerService();
                        }
                    }
                }
                return _instance;
            }
        }

        // Summary:
        //     Logs a message to a desired output, such as the console. Could be expanded for file logging, etc.
        //
        // Parameters:
        //   message:
        //     The message to log.
        public void LogMessage(string message)
        {
            Console.WriteLine("Log: " + message);
        }
    }

}
