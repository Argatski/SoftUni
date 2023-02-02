using PlayersAndMonsters.Commands.Contracts;
using System.Linq;

namespace PlayersAndMonsters.Commands
{
    public class CommandParser : ICommandParser
    {
        public ICommand Parse(string input)
        {
            var inputParts = input.Split();
            var name = inputParts[0];
            var argument = inputParts.Skip(1).ToArray();

            return new Command(name, argument);
        }
    }
}
