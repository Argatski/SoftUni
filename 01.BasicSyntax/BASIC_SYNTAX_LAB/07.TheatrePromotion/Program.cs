using System;

namespace _07.TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfday = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if (age<0 ||age>122)
            {
                Console.WriteLine("Error!");
                return;
            }

            if (typeOfday=="Weekday")
            {
                if (age>=0 && age<=18)
                {
                    price = 12;
                }
                else if (age>18 && age<=64)
                {
                    price = 18;
                }
                else if (age>64 && age <=122)
                {
                    price = 12;
                }
            }
            else if (typeOfday=="Weekend")
            {

                if (age >= 0 && age <= 18)
                {
                    price = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 15;
                }
            }
            else if (typeOfday=="Holiday")
            {

                if (age >= 0 && age <= 18)
                {
                    price = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 10;
                }
            }
            Console.WriteLine($"{price}$");
        }
    }
}
//using system;

//namespace _7.theatrepromotion
//{
//    class program
//    {
//        static void main(string[] args)
//        {
//            string day = console.readline();
//            int age = int.parse(console.readline());

//            int price = 0;

//            if (0 > age || age > 122)
//            {
//                console.writeline("error!");
//                return;
//            }

//            switch (day)
//            {
//                case "weekday":
//                    if ((0 <= age && age <= 18) || (64 < age && age <= 122))
//                    {
//                        price = 12;
//                    }
//                    else if (18 < age && age <= 64)
//                    {
//                        price = 18;
//                    }

//                    break;
//                case "weekend":
//                    if ((0 <= age && age <= 18) || (64 < age && age <= 122))
//                    {
//                        price = 15;
//                    }
//                    else if (18 < age && age <= 64)
//                    {
//                        price = 20;
//                    }
//                    break;

//                case "holiday":
//                    if (0 <= age && age <= 18)
//                    {
//                        price = 5;
//                    }
//                    else if (18 < age && age <= 64)
//                    {
//                        price = 12;
//                    }
//                    else if (64 < age && age <= 122)
//                    {
//                        price = 10;
//                    }
//                    break;

//            }

//            console.writeline($"{price}$");
//        }
//    }
//}
