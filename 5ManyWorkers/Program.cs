using _5ManyWorkers.Loggers;
using _5ManyWorkers.Workers;
using System;

namespace _5ManyWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleWorker doubleWorker = new DoubleWorker(new FileLogger(@"..\..\..\log.txt"));
            StringWorker stringWorker = new StringWorker(new FileLogger(@"..\..\..\log.txt"));
            //StringWorker stringWorker = new StringWorker(new Logger(@"..\..\..\log.txt"));
            doubleWorker.Work();
            stringWorker.Work();
            Console.Read();
        }
    }
}
