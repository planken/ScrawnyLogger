using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrawnyLogger
{
    public partial class LogEntry
    {
        public static void Add(LogEntry log)
        {
            if (log.LogIsFull)
            {
                if (log.Accumulate)
                {
                    EndLogFile(log);
                }
                else
                {
                    System.IO.File.Delete(log.FullFileName);
                }
            }
            string logMsg = $"{log.TimeStamp} {log.TypeString}{log.Source}{log.Message}";
            if(!System.IO.File.Exists(log.FullFileName))
            {
                logMsg = $"{log.TimeStamp} --> log file created '{log.FullFileName}'\r\n{logMsg}";
            }
            logMsg += $"\r\n";

            try
            {
                System.IO.File.AppendAllText(log.FullFileName, logMsg);
            }
            catch
            {
            }
        }
    }
}
