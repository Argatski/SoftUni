using System;
using System.Collections.Generic;

namespace CustomDoublyLinkedList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Input  (Instance)
            DoublyLinkedList list = new DoublyLinkedList();

            //Add numbers in head
            for (int i = 0; i < 10; i++)
            {
                list.AddFirst(i);
            }



            //Add numbers in tail
            for (int j = 0; j < 10; j++)
            {
                list.AddLast(j);
            }

            ////Remove first 3 numbers
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine($"Remove: {list.RemoveFirst()}");
            }

            //////remove last 3 numbers
            for (int z = 0; z < 3; z++)
            {
                Console.WriteLine($"remove: {list.RemoveLast()}");
            }

            //Print resutl
            list.ForEach(n => Console.WriteLine(n));

            Console.WriteLine("Print LinkedList convert to Array:");
            //Print array result
            var result = list.ToArray();
            Console.WriteLine($"{string.Join(", ",result)}");
        }
    }
}
