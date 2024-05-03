using NLog;

namespace JSONConvertor.Helper
{
    public static class LogHelper
    {
        private static Logger Log = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Log Information
        /// </summary>
        /// <param name="message">Message</param>
        public static void LogInfo(string message)
        {
            Log.Info(message);
        }

        /// <summary>
        /// Log Warning
        /// </summary>
        /// <param name="message">Message</param>
        public static void LogWarn(string message)
        {
            Log.Warn(message);
        }

        /// <summary>
        /// Log Error
        /// </summary>
        /// <param name="message">Message</param>
        public static void LogError(string message)
        {
            Log.Error(message);
        }

    }
}
