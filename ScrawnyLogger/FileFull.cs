using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrawnyLogger
{
    public partial class LogEntry
    {
        private bool LogFileIsFull()
        {
            bool output = false;
            if (System.IO.File.Exists(FullFileName))
            {
                long maxBytes = MaxLogFileBytes();
                System.IO.FileInfo fi = new(FullFileName);
                output = fi.Length > maxBytes & maxBytes > 0;
            }
            return output;
        }
    }
}
