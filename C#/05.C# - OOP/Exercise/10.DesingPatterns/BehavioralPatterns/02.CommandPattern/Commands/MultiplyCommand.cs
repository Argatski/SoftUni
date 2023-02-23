using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CommandPattern.Commands
{
    internal class MultiplyCommand : ICommand
    {
        public MultiplyCommand(int operand) : base(operand)
        {
        }

        public override int Calculate(int currentValue)
        {
            return currentValue * operand;
        }

        public override  int UndoCalculation(int currentValue)
        {
            return currentValue / operand;
        }
    }
}
