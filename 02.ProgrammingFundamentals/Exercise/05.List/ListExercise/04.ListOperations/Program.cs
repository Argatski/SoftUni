using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<int> numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToList();

            //Solution
            ListOperations(numbers);
        }

        static void ListOperations(List<int> numbers)
        {
            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "End")
                {
                    Console.WriteLine(string.Join(' ', numbers));

                    break;
                }



                switch (command[0])
                {
                    case "Add":
                        int num = int.Parse(command[1]);
                        numbers.Add(num);
                        break;

                    case "Remove":
                        int position = int.Parse(command[1]);
                        if (position >= numbers.Count || position < 0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        numbers.RemoveAt(position);
                        break;
                    case "Insert":
                        position = int.Parse(command[2]);
                        int number = int.Parse(command[1]);

                        if (position >= numbers.Count || position<0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }

                        numbers.Insert(position, number);
                        break;

                    case "Shift":
                        int count = int.Parse(command[2]);
                        int currentNum = 0;

                        if (command[1] == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                currentNum = numbers[0];
                                for (int k = 0; k < numbers.Count-1; k++)
                                {
                                    numbers[k] = numbers[k + 1];
                                }
                                numbers[numbers.Count - 1] = currentNum;
                            }
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                currentNum = numbers[numbers.Count-1];
                                for (int k = numbers.Count-1; k > 0; k--)
                                {
                                    numbers[k] = numbers[k-1];
                                }
                                numbers[0] = currentNum;
                            }
                        }
                        break;
                   
                }

            }

        }
    }
}
