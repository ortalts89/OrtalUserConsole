using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class Log : ILog, IDisposable
    {
        private bool dispose;
        private const string LogFilePath = @"C: \Users\ortal.t\Documents\OrtalLogFile.txt";

        public string _LogFilePath => LogFilePath;

        public string GetLog()
        {
            return File.ReadAllText(_LogFilePath);
        }

        public void WriteToLog(string message)
        {
            var log = !File.Exists(_LogFilePath) ? new StreamWriter(_LogFilePath) : File.AppendText(_LogFilePath);

            log.Write(DateTime.Now + " ");
            log.Write(message);
            log.WriteLine();
            log.Close();
            
        }


        public void Dispose()
        {
            
        }
    }
}
