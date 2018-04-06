using _6LoggerInterface.Loggers;
using _6LoggerInterface.Workers;
using System;

namespace _6LoggerInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger
                //= new Logger();
                = new FileLogger(@"..\..\..\log.txt");
            DoubleWorker doubleWorker = new DoubleWorker(logger);
            StringWorker stringWorker = new StringWorker(logger);
            doubleWorker.Work();
            stringWorker.Work();
            Console.Read();
        }
    }
}
