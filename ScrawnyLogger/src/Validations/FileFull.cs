namespace ScrawnyLogger
{
    public partial class LogEntry
    {
        private bool LogFileIsFull()
        {
            bool output = false;
            long maxBytes = MaxLogFileBytes();
            if (maxBytes <= 0) return output;
            if (System.IO.File.Exists(FullFileName))
            {
                System.IO.FileInfo fi = new(FullFileName);
                output = fi.Length > maxBytes;
            }
            return output;
        }
    }
}