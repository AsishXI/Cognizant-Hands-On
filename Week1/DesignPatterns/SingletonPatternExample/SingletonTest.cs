using System;

namespace Singleton
{
    public class SingletonTest
    {
        public static void Test()
        {
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            logger1.Log("First message");
            logger2.Log("Second message");

            if (logger1 == logger2)
            {
                Console.WriteLine("Only one Logger instance is created.");
            }
            else
            {
                Console.WriteLine("Multiple Logger instances are created.");
            }
        }
    }
}