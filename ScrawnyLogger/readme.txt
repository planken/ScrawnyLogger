Sample wrapper:






    public static class LogMsg
    {
        private static void Add(string message, LogEntry.Severity severity, bool callerRequested)
        {
            // Defaults to app name and folder.
            LogEntry log = new()
            {
                LogFileName = "logfile.log",
                LogFolder = "\\server\share",
                Type = severity,
                CallerRequest = callerRequested,
                LogFileMaxMB = 1.5f,
                Message = message
            };
            LogEntry.Add(log);
        }

        public static void AddCritical(string message)
        {
            Add(message, LogEntry.Severity.Critical, false);
        }

        public static void AddCritical(string message, bool requestCaller)
        {
            Add(message, LogEntry.Severity.Critical, requestCaller);
        }

        public static void AddError(string message)
        {
            Add(message, LogEntry.Severity.Error, false);
        }

        public static void AddError(string message, bool requestCaller)
        {
            Add(message, LogEntry.Severity.Error, requestCaller);
        }

        public static void AddWarning(string message)
        {
            Add(message, LogEntry.Severity.Warning, false);
        }

        public static void AddDebug(string message)
        {
            Add(message, LogEntry.Severity.Debug, false);
        }

        public static void AddInfo(string message)
        {
            Add(message, LogEntry.Severity.Info, false);
        }
    }
