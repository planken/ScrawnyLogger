using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrawnyLogger
{
    public partial class LogEntry
    {
        private string ForceExtension()
        {
            string output = LogFileName;
            string extension = System.IO.Path.GetExtension(output);
            if (extension.ToLower() != LogExtension.ToLower())
            {
                output += LogExtension;
            }
            output = System.IO.Path.Combine(LogFolder, output);
            return output;
        }
    }
}
