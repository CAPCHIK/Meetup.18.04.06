
using _6LoggerInterface.Loggers;

namespace _6LoggerInterface.Workers
{
    class DoubleWorker
    {
        private readonly ILogger logger;

        public DoubleWorker(ILogger logger)
        {
            this.logger = logger;
        }
        public void Work()
        {
            logger.Log(0.5);
            logger.Log(23.6);
            logger.Log(6456.2);
        }
    }
}
