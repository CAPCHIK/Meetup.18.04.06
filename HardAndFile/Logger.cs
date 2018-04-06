using System;
using System.Collections.Generic;
using System.Text;

namespace HardAndFile
{
    class Logger
    {
        public void Log(object data)
        {
            Console.WriteLine(data?.ToString());
        }
    }
}
