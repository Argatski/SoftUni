using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        //Methods
        public static double Calculates(string first, string second)
        {
            var firstDate = DateTime.ParseExact(first, "yyyy MM dd", CultureInfo.InvariantCulture);

            var secondDate = DateTime.ParseExact(second, "yyyy MM dd",
                CultureInfo.InvariantCulture);

            if (firstDate > secondDate)
            {
                return Calculates(second, first);
            }
            return (secondDate - firstDate).Days;
        }
    }
}
