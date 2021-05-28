using System;

namespace ScrawnyLogger
{
    public partial class LogEntry
    {
        private long MaxLogFileBytes()
        {
            long output = Convert.ToInt64(LogFileMaxMB * Math.Pow(1024, 2));
            return output;
        }
    }
}