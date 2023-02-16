using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SingletonPattern
{
    public sealed class LoggerSingleton
    {
        private static LoggerSingleton instance;
        private static object _lock = new object();
        private LoggerSingleton() { }

        public void LogToFile()
        {
            Console.WriteLine("Logged to file");
        }
        public static LoggerSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            Console.WriteLine("Created instance only once.");
                            instance = new LoggerSingleton();

                        }

                    }
                    
                }
                return instance;
            }
        }
    }
}