using System;
using System.Collections.Generic;
using System.Text;

namespace _6LoggerInterface.Loggers
{
    class Logger : ILogger
    {
        public void Log(object data)
        {
            Console.WriteLine(data?.ToString());
        }
    }
}
