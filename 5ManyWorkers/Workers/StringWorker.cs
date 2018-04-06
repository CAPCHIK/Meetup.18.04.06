using _5ManyWorkers.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5ManyWorkers.Workers
{
    class StringWorker
    {
        private readonly FileLogger logger;

        public StringWorker(FileLogger logger)
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
