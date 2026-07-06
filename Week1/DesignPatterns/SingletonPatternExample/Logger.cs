using System;

namespace Singleton
{
    public class Logger
    {
        private static Logger? logger = null;

        private Logger()
        {
        }

        public static Logger GetInstance()
        {
            if (logger == null)
            {
                logger = new Logger();
            }

            return logger;
        }

        public void Log(string message)
        {
            Console.WriteLine("[LOG] " + message);
        }
    }
}