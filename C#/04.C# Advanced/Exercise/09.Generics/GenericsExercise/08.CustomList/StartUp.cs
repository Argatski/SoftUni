using System;

namespace CustomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Instance LinkedList
            var customList = new CustomList<string>();

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (input[0])
                {
                    case "Add":
                        var element = input[1];
                        customList.Add(element);
                        break;
                    case "Remove":
                        var index = int.Parse(input[1]);
                        customList.Remove(index);
                        break;
                    case "Contains":
                        string text = input[1];
                        bool isContains = customList.Contains(text);
                        Console.WriteLine(isContains);
                        break;
                    case "Swap":
                        int firstIndex = int.Parse(input[1]);
                        int secondIndex = int.Parse(input[2]);
                        customList.Swap(firstIndex, secondIndex);
                        break;
                    case "Greater":
                        string greaterElement = input[1];
                        Console.WriteLine(customList.Greater(greaterElement));
                        break;
                    case "Max":
                        Console.WriteLine(customList.Max());
                        break;
                    case "Min":
                        Console.WriteLine(customList.Min());
                        break;
                    case "Print":
                        Console.Write(customList);
                        break;
                }
            }


        }
    }
}
//Another sulution
/*
 var list = new CustomList<string>();

string command;

while((command = Console.ReadLine()) != "END")
{
string[] tokens = command.Split();

switch (tokens[0])
{
    case "Add":
        list.Add(tokens[1]);
        break;
    case "Remove":
        list.Remove(int.Parse(tokens[1]));
        break;
    case "Contains":
        Console.WriteLine(list.Contains(tokens[1]));
        break;
    case "Swap":
        list.Swap(int.Parse(tokens[1]), int.Parse(tokens[2]));
        break;
    case "Greater":
        Console.WriteLine(list.CountGreaterThan(tokens[1]));
        break;
    case "Max":
        Console.WriteLine(list.Max());
        break;
    case "Min":
        Console.WriteLine(list.Min());
        break;
    case "Print":
        Console.WriteLine(list);
        break;
    default:
        throw new ArgumentException();
}
}
 */