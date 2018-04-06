using _10DI.Loggers;
using _10DI.Workers;
using System;

namespace _10DI
{
    class Program
    {
        static void Main(string[] args)
        {
            OurDI container = new OurDI();
            Configure(container);


            DoubleWorker doubleWorker = container.Resolve<DoubleWorker>();
            StringWorker stringWorker = container.Resolve<StringWorker>();

            doubleWorker.Work();
            stringWorker.Work();

            Console.Read();
        }

        static void Configure(OurDI container)
        {
            container.Set<ILogger, Logger>();
        }
    }
}
