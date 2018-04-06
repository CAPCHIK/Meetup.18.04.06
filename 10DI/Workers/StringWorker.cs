using _10DI.Loggers;

namespace _10DI.Workers
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
