using System;
using System.Collections.Generic;
using System.Text;

namespace _4ExtractWork.Loggers
{
    class Logger
    {
        public void Log(object data)
        {
            Console.WriteLine(data?.ToString());
        }
    }
}
