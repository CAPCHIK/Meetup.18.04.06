using System;
using System.Collections.Generic;
using System.Text;

namespace _5ManyWorkers.Loggers
{
    class Logger
    {
        public void Log(object data)
        {
            Console.WriteLine(data?.ToString());
        }
    }
}
