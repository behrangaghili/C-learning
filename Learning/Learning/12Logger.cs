using Serilog;
 

namespace learning
{
    public class Logger
    {
        private readonly ILogger _log;

        // Constructor to initialize the Serilog logger
        public Logger()
        {
            // Configure Serilog
            _log = new LoggerConfiguration()
                .WriteTo.Console() // Log to the console
                .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day) // Log to a file, with daily rolling
                .CreateLogger();
        }

        // Method to log a message
        public void Print(string message)
        {
            _log.Information(message);
        }
    }

}
