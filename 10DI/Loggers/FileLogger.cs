using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _10DI.Loggers
{
    class FileLogger : ILogger
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
