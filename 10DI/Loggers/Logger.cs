﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _10DI.Loggers
{
    class Logger : ILogger
    {
        public void Log(object data)
        {
            Console.WriteLine(data?.ToString());
        }
    }
}
