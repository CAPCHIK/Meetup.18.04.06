using _4ExtractWork.Loggers;

namespace _4ExtractWork
{
    class Worker
    {
        private readonly FileLogger logger;

        public Worker(FileLogger logger)
        {
            this.logger = logger;
        }
        public void Work()
        {
            logger.Log("Start work");
            logger.Log("do new work");
            logger.Log("need array:");
            logger.Log(5);
            logger.Log(2);
            logger.Log(5.6);
        }
    }
}
