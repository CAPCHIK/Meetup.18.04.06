using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _5ManyWorkers.Loggers
{
    class FileLogger
    {
        private readonly string fileForLog;

        public FileLogger(string fileForLog)
        {
            this.fileForLog = fileForLog;
        }
        public void Log(object data)
        {
            File.AppendAllText(fileForLog, data.ToString() + Environment.NewLine);
        }
    }
}
