using _6LoggerInterface.Loggers;

namespace _6LoggerInterface.Workers
{
    class StringWorker
    {
        private readonly ILogger logger;

        public StringWorker(ILogger logger)
        {
            this.logger = logger;
        }
        public void Work()
        {
            logger.Log("Start work");
            logger.Log("do new work");
            logger.Log("need array:");
        }
    }
}
