using System;
using System.Linq;

namespace _01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string message = Console.ReadLine();

            //Processing

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] instructions = command.Split(":|:");

                switch (instructions[0])
                {
                    case "InsertSpace":
                        message = InsertSpace(instructions, message);
                        break;

                    case "Reverse":
                        message = ReverseMassage(instructions, message);
                        break;

                    case "ChangeAll":
                        message = ChangeAll(instructions, message);
                        break;
                }
            }
            Console.WriteLine($"You have a new text message: {message}");

        }

        static string ChangeAll(string[] instructions, string message)
        {
            string substring = instructions[1];
            string replacement = instructions[2];

            if (message.Contains(substring))
            {
                message = message.Replace(substring, replacement);
                Console.WriteLine(message);
            }
            return message;
        }

        static string ReverseMassage(string[] instructions, string message)
        {
            string substring = instructions[1];

            if (message.Contains(substring))
            {
                int index = message.IndexOf(substring);
                message = message.Remove(index, substring.Length);

                //Reverse string and add it at the end
                char[] reverse = substring.ToCharArray();
                Array.Reverse(reverse);
                string result = new String(reverse);
                message += result;

                Console.WriteLine(message);

            }
            else
            {
                Console.WriteLine("error");
            }
            return message;
        }

        static string InsertSpace(string[] instructions, string mess)
        {
            int index = int.Parse(instructions[1]);

            mess = mess.Insert(index, " ");

            Console.WriteLine(mess);

            return mess;
        }
    }
}
