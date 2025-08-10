using System;

namespace SingletonPatternExample
{
    public class Logger
    {
        private static Logger? _instance;

        private Logger()
        {
            Console.WriteLine("Logger Instance Created");
        }

        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        public void Log(string message)
        {
            Console.WriteLine("Log: " + message);
        }
    }
}
