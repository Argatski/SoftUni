using SOLID_Exercises.Core;
using SOLID_Exercises.Factories;
using SOLID_Exercises.Models;
using SOLID_Exercises.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID_Exercises
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var appenderCount = int.Parse(Console.ReadLine());

            var appenders = new List<IAppender>();
            var layoutFactory = new LayoutFactory();
            var logFileFactory = new LogFileFactory();
            var appenderFactory = new AppenderFactory(layoutFactory, logFileFactory);

            ReadAppenderData(appenderCount, appenders, appenderFactory);

            var logger = new Logger(appenders);
            var errorFactory = new ErrorFactory();

            var engine = new Engine(logger, errorFactory);

            engine.Run();
        }

        private static void ReadAppenderData(
            int appenderCount,
            ICollection<IAppender> appenders,
            AppenderFactory appenderFactory)
        {
            for (int i = 0; i < appenderCount; i++)
            {
                var appendersInfo = Console.ReadLine()
                .Split()
                .ToArray();

                var appenderType = appendersInfo[0];
                var layoutType = appendersInfo[1];
                var level = "INFO";

                if (appendersInfo.Length == 3)
                {
                    level = appendersInfo[2];
                }

                try
                {
                    var appender = appenderFactory.GetAppender(appenderType, layoutType, level);
                    appenders.Add(appender);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }

        }
    }
}
