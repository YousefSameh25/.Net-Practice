using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Logger
    {
        public LogLevel LogLevel { get; set; }

        private Logger() { }

        private static Logger _logger;
        private static readonly Object locker = new object();
        public static Logger logger
        {
            get
            {
                if (_logger is null)
                {
                    // The threads will reach this check at the first time only.
                    lock (locker)
                    {
                        if (_logger is null)
                            _logger = new Logger();
                    }
                }
                return _logger;
            }
        }

        public void LogDebug(string message)
        {
            if ((int)LogLevel >= (int)LogLevel.Debug)
                Console.WriteLine($"Debug: {message}");
        }

        public void LogInfo(string message)
        {
            if ((int)LogLevel >= (int)LogLevel.Info)
                Console.WriteLine($"Info: {message}");
        }

        public void LogWarn(string message)
        {
            if ((int)LogLevel >= (int)LogLevel.Warn)
                Console.WriteLine($"Warn: {message}");
        }

        public void LogError(string message)
        {
            if ((int)LogLevel >= (int)LogLevel.Error)
                Console.WriteLine($"Error: {message}");
        }

        public void LogFatal(string message)
        {
            if ((int)LogLevel >= (int)LogLevel.Fatal)
                Console.WriteLine($"Fatal: {message}");
        }

    }
}
