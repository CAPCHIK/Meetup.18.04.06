using _5ManyWorkers.Loggers;

namespace _5ManyWorkers.Workers
{
    class DoubleWorker
    {
        private readonly FileLogger logger;

        public DoubleWorker(FileLogger logger)
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
