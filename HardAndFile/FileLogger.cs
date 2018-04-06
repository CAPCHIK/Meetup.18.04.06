using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HardAndFile
{
    class FileLogger
    {
        public void Log(object data, string fileForLog)
        {
            File.AppendAllText(fileForLog, data.ToString() + Environment.NewLine);
        }
    }
}
