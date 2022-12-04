using SOLID_Exercises.Core.Contracts;
using SOLID_Exercises.Factories.Contracts;
using SOLID_Exercises.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID_Exercises.Core
{
    public class Engine : IEngine
    {
        private readonly ILogger logger;
        private readonly IErrorFactory errorFactory;
        public Engine(ILogger logger, IErrorFactory errorFactory)
        {
            this.logger = logger;
            this.errorFactory = errorFactory;
        }
        public void Run()
        {
            var command = Console.ReadLine();

            while (command != "END")
            {
                var errorArguments = command
                    .Split("|")
                    .ToArray();

                var level = errorArguments[0];
                var date = errorArguments[1];
                var messege = errorArguments[2];

                try
                {
                    var error = this.errorFactory.GetError(date, level, messege);
                    this.logger.Log(error);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(this.logger);
        }
    }
}
