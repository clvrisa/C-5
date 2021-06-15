using System;
namespace C5
{
    public class Exercise5
    {
        public delegate void LogHandler(string message);
        public void process(LogHandler logHandler)
        {
            if (logHandler != null)
            {
                logHandler("begin");
            }
            if (logHandler != null)
            {
                logHandler("End");
            }
        }
        public class MyLogger
        {
            public void logger(string s)
            {
                Console.WriteLine(s);
            }
        }
        public class TestApplication
        {
            static void Logger(string s)
            {
                Console.WriteLine(s);
            }
        }
        static void Main (string[] args)
        {
            MyLogger f1 = new MyLogger();
            Exercise5 exercise5 = new Exercise5();
            Exercise5.LogHandler myLogger = null;
            MyLogger += new Exercise5.LogHandler(myLogger);
            MyLogger += new Exercise5.LogHandler(f1.logger);
            Exercise5.process(ref myLogger);
            return;
        }
    }
}
