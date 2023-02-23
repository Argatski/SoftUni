using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CommandPattern.Commands
{
    public abstract class ICommand
    {

        protected int operand;

        public ICommand(int operand)
        {
            this.operand = operand;
        }

        public abstract int Calculate(int currentValue);

        public abstract int UndoCalculation(int currentValue);
    }
}
