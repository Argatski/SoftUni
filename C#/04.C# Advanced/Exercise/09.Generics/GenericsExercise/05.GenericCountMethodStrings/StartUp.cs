using System;

namespace GenericCountMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //On the first line, you will receive n - the number of elements to add to the list.
            int n = int.Parse(Console.ReadLine());

            //Instance
            Box<string> box = new Box<string>();

            //On the next n lines, you will receive the actual elements.
            for (int i = 0; i < n; i++)
            {
                string elements = Console.ReadLine();

                box.Add(elements);
            }

            //On the last line, you will get the value of the element for comparison.
            string value = Console.ReadLine();

            //Print count of elements that are larger than the value.

            Console.WriteLine(box.GetCount(value));
        }
    }
}
