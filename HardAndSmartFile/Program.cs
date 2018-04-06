using System;

namespace HardAndSmartFile
{
    class Program
    {

        static FileLogger logger;
        static void Main(string[] args)
        {
            logger = new FileLogger("logs.txt");
            HardWork();
            Console.ReadKey();
        }


        static void HardWork()
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
