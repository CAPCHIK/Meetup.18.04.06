using System;

namespace HardAndFile
{
    class Program
    {
        static FileLogger logger;
        static void Main(string[] args)
        {
            logger = new FileLogger();
            HardWork();
            Console.ReadKey();
        }


        static void HardWork()
        {
            logger.Log("Start work",    "logs.txt");
            logger.Log("do new work",   "logs.txt");
            logger.Log("need array:",   "logs.txt");
            logger.Log(5,               "logs.txt");
            logger.Log(2,               "logs.tst");
            logger.Log(5.6,             "logs.txt");
        }
    }
}
