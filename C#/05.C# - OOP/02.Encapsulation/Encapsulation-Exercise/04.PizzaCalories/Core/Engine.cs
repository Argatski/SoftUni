namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Engine
    {

        public void Run()
        {
            try
            {
                var pizza = MakePizza();

                var input = Console.ReadLine();
                while (input != "END")
                {
                    var inputParts = input
                        .Split();

                    var command = inputParts[0];

                    var toppingType = inputParts[1];
                    var weight = double.Parse(inputParts[2]);

                    var topping = new Topping(toppingType, weight);

                    pizza.AddTopping(topping);

                    input = Console.ReadLine();
                }
                Console.WriteLine(pizza);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        private static Pizza MakePizza()
        {
            var pizzaName = Console.ReadLine()
                .Split()[1];

            var doughtInfo = Console.ReadLine()
                .Split();

            var fourType = doughtInfo[1];
            var bakingTechnique = doughtInfo[2];
            var doughWeight = double.Parse(doughtInfo[3]);

            var dough = new Dough(fourType, bakingTechnique, doughWeight);

            return new Pizza(pizzaName, dough);
        }
    }
}
