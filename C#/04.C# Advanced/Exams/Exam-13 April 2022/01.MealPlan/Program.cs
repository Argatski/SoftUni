using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01.MealPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input 
            Queue<string> meals = new Queue<string>(Console.ReadLine()
                .Split(" "));

            Stack<int> dailyCalories = new Stack<int>
                (Console.ReadLine()
                .Split(" ")
                .Select(int.Parse).ToArray());

            int numMeals = meals.Count;

            //Solution
            MealPlan(meals, dailyCalories);

            //Output
            OutputPrintResult(meals, dailyCalories, numMeals);
        }
        /// <summary>
        /// As a result, you should print two lines for output:
        /// If John menage to eat all the given meals print:
        /// If John could not eat every meal:
        /// </summary>
        /// <param name="meals"></param>
        /// <param name="dailyCalories"></param>
        /// <param name="numMeals"></param>
        private static void OutputPrintResult(Queue<string> meals, Stack<int> dailyCalories, int numMeals)
        {
            if (meals.Count == 0)
            {
                Console.WriteLine($"John had {numMeals - meals.Count} meals.");

                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", dailyCalories)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {numMeals - meals.Count} meals.");

                Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
            }
        }

        /// <summary>
        /// Calculate calories intake,ny predefined meals.
        /// </summary>
        /// <param name="meals"></param>
        /// <param name="dailyCalories"></param>
        private static void MealPlan(Queue<string> meals, Stack<int> dailyCalories)
        {
            //Meals and their calories
            Dictionary<string, int> table = new Dictionary<string, int>
          {
              { "salad",350 },
              { "soup",490 },
              { "pasta",680 },
              { "steak",790 }
          };

            //Solution
            while (meals.Count > 0 && dailyCalories.Count > 0)
            {
                string currentMeal = meals.Dequeue();
                int mealCalories = table[currentMeal];

                int currentCalories = dailyCalories.Pop();

                currentCalories -= mealCalories;

                while (currentCalories < 0)
                {
                    if (dailyCalories.Count == 0)
                    {
                        break;
                    }
                    int restCalor = dailyCalories.Pop();
                    restCalor += currentCalories;

                    currentCalories = restCalor;
                }

                if (currentCalories > 0)
                {
                    dailyCalories.Push(currentCalories);
                }
            }

        }
    }
}
