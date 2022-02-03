using System;
using System.Collections.Generic;

namespace _08.Implementing_List_and_Stack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            
            //Instace custom list
            CustomList list = new CustomList();

            //Test add method in custom list
            for (int i = 0; i < 4; i++)
            {
                list.Add(i);
            }



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

        }
    }
}
