using System;

namespace ScrawnyLogger
{
    public partial class LogEntry
    {
        private static void EndLogFile(LogEntry log)
        {
            string baseName = System.IO.Path.GetFileNameWithoutExtension(log.FullFileName);
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss_fff");
            string newFileName = $"{baseName}_{timestamp}{log.LogExtension}";
            string newFilePath = System.IO.Path.Combine(log.LogFolder, newFileName);
            string logMsg = $"{log.TimeStamp} --> Log file full, renamed to '{newFileName}'\r\n";

            try
            {
                System.IO.File.AppendAllText(log.FullFileName, logMsg);
                System.IO.File.Move(log.FullFileName, newFilePath);
            }
            catch
            {
                // TODO: If append/move fails, consider logging to event log.
            }
        }
    }
}