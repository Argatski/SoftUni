using System;
using System.Collections.Generic;

namespace _08.Implementing_List_and_Stack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            /*
            CustomStack customStack = new CustomStack();
            customStack.Push(10);
            customStack.Push(20);
            customStack.Push(30);
            customStack.Push(40);
            customStack.Push(50);
            customStack.Push(60);
            customStack.Push(70);
            customStack.Push(80);

            customStack.Peek();
            customStack.Pop();
            customStack.ForEach(x => Console.WriteLine(x));
            */



            //Instace custom list
            CustomList list = new CustomList();

            //Test add method in custom list
            for (int i = 0; i < 4; i++)
            {
                list.Add(i);
            }

            list.ForEach(x => Console.WriteLine(x));

            /*

            ////Test RemoveAt
            //list.RemoveAt(1);
            //list.RemoveAt(1);
            //list.RemoveAt(1);



            ////Test insert
            //list.Insert(4, 20);

            ////Test contains
            //Console.WriteLine(list.Contains(20));
            //Console.WriteLine(list.Contains(100));

            ////Test swap
            //list.Swap(1, 3);
            //list.Swap(10, 2);


            ////Test reverse array
            //list.Reverse();

            //Test Tostring method
            Console.WriteLine(list.Tostring());
            */
        }
    }
}
