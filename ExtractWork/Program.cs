using _4ExtractWork.Loggers;
using System;

namespace _4ExtractWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker(new FileLogger(@"..\..\..\logs.txt"));
            worker.Work();
            Console.ReadKey();
        }
    }
}
