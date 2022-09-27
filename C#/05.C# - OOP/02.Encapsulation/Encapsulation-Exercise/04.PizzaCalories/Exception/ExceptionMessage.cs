using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class ExceptionMessage
    {
        public static string invalidTupe = "Invalid type of dough.";
        public static string invalidWeight = "Dough weight should be in the range [1..200].";

        public static string invalidtToppingType = "Cannot place {0} on top of your pizza.";
        public static string invalidtToppingWeight = "{0} weight should be in the range [1..50].";

        public static string invalidtLenghtName = "Pizza name should be between 1 and 15 symbols.";

        public static string invalidToppingsRange = "Number of toppings should be in range [0..10].";
    }
}
