using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal interface ILog
    {
        string _LogFilePath { get;} 
        string GetLog();
        void WriteToLog(string message);
    }
}
