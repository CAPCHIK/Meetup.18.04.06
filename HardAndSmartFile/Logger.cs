using System;
using System.Collections.Generic;
using System.Text;

namespace HardAndSmartFile
{
    class Logger
    {
        public void Log(object data)
        {
            Console.WriteLine(data?.ToString());
        }
    }
}
