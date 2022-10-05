using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {

        public string Browsing(string site)
        {
            if (site.Any(x => char.IsDigit(x)))
            {
                throw new ArgumentException(ExceptionMassage.invalidURL);
            }

            return $"Browsing: {site}!";
        }

        public string Call(string number)
        {
            if (number.Any(n => char.IsLetter(n)))
            {
                throw new ArgumentException(ExceptionMassage.invalidNumber);
            }

            string resutl = $"Calling... {number}";
            return resutl;
        }

    }
}
