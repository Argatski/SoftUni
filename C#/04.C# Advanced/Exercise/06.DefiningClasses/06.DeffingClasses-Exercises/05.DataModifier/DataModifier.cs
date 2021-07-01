using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DefiningClasses
{
    class DataModifier
    {
        //Methods

        public static
            double Calculates(string first, string last)
        {
            var firstDate = DateTime.ParseExact(first, "yyyy MM dd", CultureInfo.InvariantCulture);
            var secondDate = DateTime.ParseExact(last, "yyyy MM dd", CultureInfo.InvariantCulture);


            if (firstDate > secondDate)
            {
                return Calculates(last, first);
            }

            return (secondDate - firstDate).Days;
        }
    }
}
