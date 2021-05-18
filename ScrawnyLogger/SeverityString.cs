using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrawnyLogger
{
    public partial class LogEntry
    {
        private string SeverityString()
        {
            string output = Type.ToString().PadRight(9).ToUpper();
            return output;
        }
    }
}
