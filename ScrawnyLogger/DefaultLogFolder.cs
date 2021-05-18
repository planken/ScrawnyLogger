namespace ScrawnyLogger
{
    public partial class LogEntry
    {
        private static string DefaultLogFolder()
        {
            string exe = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string exePath = System.IO.Path.GetDirectoryName(exe);
            return exePath;
        }
    }
}