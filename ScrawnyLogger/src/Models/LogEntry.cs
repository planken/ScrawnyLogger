using System;

namespace ScrawnyLogger
{
    public partial class LogEntry
    {
        private const string _timeStampFormat = "yyyy-MM-dd HH:mm:ss.fff";
        public string TimeStamp { get; } = DateTime.Now.ToString(_timeStampFormat);
        public string LogExtension { get; } = ".log";
        public string LogFileName { get; set; } = DefaultLogName();
        public string LogFolder { get; set; } = DefaultLogFolder();
        public bool Accumulate { get; set; } = true;
        public int SkipStack { get; set; } = 5;
        public bool CallerRequest { get; set; } = false;
        public Severity Type { get; set; } = Severity.Info;
        public string Message { get; set; } = string.Empty;
        private string Source => GetCaller();
        private string TypeString => SeverityString();
        public float LogFileMaxMB { get; set; } = 1.5f;
        private string FullFileName => ForceExtension();
        private bool LogIsFull => LogFileIsFull();
    }
}