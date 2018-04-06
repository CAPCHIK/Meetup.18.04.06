using System;

namespace Hard
{
    class Program
    {
        static Logger logger;
        static void Main(string[] args)
        {
            logger = new Logger();
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
