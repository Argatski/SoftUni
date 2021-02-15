using System;

namespace _01.TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //input message
            string message = Console.ReadLine();

            //Processing
            message = Processing(message);

            Console.WriteLine($"The decrypted message is: {message}");

        }

        static string Processing(string message)
        {
            string arg = string.Empty;

            while ((arg = Console.ReadLine()) != "Decode")
            {
                string[] instructions = arg.Split('|');

                string command = instructions[0];

                switch (command)
                {
                    case "Move":
                        message = MoveWord(message, instructions);
                        break;
                    case "Insert":
                        message = InsertWord(message, instructions);
                        break;
                    case "ChangeAll":
                        message = ChangeAllWord(message, instructions);
                        break;
                }
            }
            return message;
        }

        static string ChangeAllWord(string message, string[] instructions)
        {
            string substring = instructions[1];
            string replacement = instructions[2];
            message = message.Replace(substring, replacement);

            return message;
        }

        static string InsertWord(string message, string[] instructions)
        {
            int index = int.Parse(instructions[1]);
            string word = instructions[2];

            message = message.Insert(index, word);

            return message;
        }

        static string MoveWord(string message, string[] instructions)
        {
            int lenght = int.Parse(instructions[1]);
            string word = message.Substring(0, lenght);

            message = message.Remove(0, lenght);
            message += word;

            return message;
        }
    }
}
