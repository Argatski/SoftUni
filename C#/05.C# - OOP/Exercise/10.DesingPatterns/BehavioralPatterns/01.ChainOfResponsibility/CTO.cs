using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ChainOfResponsibility
{
    internal class CTO : Approver
    {
        public override bool HandleRequest(int amount)
        {
            if (amount < 500)
            {
                Console.WriteLine("Get this money.");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
