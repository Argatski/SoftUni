using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            var argumentParts = args
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var commandName = argumentParts[0];
            var commandArguments = argumentParts.Skip(1).ToArray();

            var commandType = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .Where(n => n.Name == $"{commandName}Command")
                .FirstOrDefault();

            var commandInstance = Activator.CreateInstance(commandType) as ICommand;

            var result = commandInstance.Execute(commandArguments);
            return result;
        }
    }
}
