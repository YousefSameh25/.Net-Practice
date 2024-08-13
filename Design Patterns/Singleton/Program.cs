namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.logger;
            logger.LogLevel = LogLevel.Debug;

            logger.LogDebug("Test");

        }
    }
}
