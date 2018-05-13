using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class Log : ILog
    {
        private const string FilePath = @"C: \Users\ortal.t\Documents\OrtalLogFile.txt";

        public string LogFilePath => FilePath;

        public string GetLog()
        {
            return File.ReadAllText(LogFilePath);
        }

        public void WriteToLog(string message)
        {
            var log = !File.Exists(LogFilePath) ? new StreamWriter(LogFilePath) : File.AppendText(LogFilePath);

            log.Write(DateTime.Now + " ");
            log.Write(message);
            log.WriteLine();
            log.Close();
            
        }
    }
}
