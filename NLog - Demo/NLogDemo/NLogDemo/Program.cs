using NLog;
using System;

namespace NLogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Logger log = LogManager.GetCurrentClassLogger();

            log.Debug("This is a debug message");
            log.Error(new Exception(), "This is an error message");
            log.Fatal("This is a fatal message");

        }
    }
}
