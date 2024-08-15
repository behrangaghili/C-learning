using Serilog;
 

namespace learning 
{
    public class logger
    {
        private readonly ILogger  log;

        public logger( )
        {
        }

       
        public void print(string message)
        {
            log.Information(message);
        }
    }
}
