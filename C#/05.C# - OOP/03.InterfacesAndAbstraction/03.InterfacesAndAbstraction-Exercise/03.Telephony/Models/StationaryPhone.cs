using System;
using System.Linq;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        /// <summary>
        /// If the number is 7 digits long, you are making a call from your stationary phone and you print:
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Dialing... {number}</returns>
        public string Call(string number)
        {
            if (number.Any(n => char.IsLetter(n)))
            {
                Console.WriteLine(ExceptionMassage.invalidNumber);
            }

            string resutl = $"Dialing... {number}";
            return resutl;
        }
    }
}
