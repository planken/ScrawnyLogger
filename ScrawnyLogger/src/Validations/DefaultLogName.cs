using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrawnyLogger
{
    public partial class LogEntry
    {
        private static string DefaultLogName()
        {
            string output = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            return output;
        }
    }
}
