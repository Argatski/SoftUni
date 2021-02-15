using System;
using System.Linq;
namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            PasswordValidator(password);
        }

        private static void PasswordValidator(string password)
        {
            if (password.Count(Char.IsDigit) >= 2 && password.Length >= 6 && password.Length <= 10 && password.All(Char.IsLetterOrDigit))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!(password.Length >= 6 && password.Length <= 10))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!password.All(Char.IsLetterOrDigit))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!(password.Count(Char.IsDigit) >= 2))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }
    }
}




//using System;


//namespace _04.PasswordValidator
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Input 
//            string password = Console.ReadLine();
//            string printNumSum = "";
//            string printConsist = "";
//            string printMinDigits = "";

//            //Output
//            printNumSum = NumberSumbol(password);
//            printConsist = Consist(password);
//            printMinDigits = ContainsMinDigits(password);

//            if (printNumSum == "true" && printConsist == "true" && printMinDigits == "true")
//            {
//                Console.WriteLine("Password is valid");
//            }
//            if (printNumSum == "Password must be between 6 and 10 characters")
//            {
//                Console.WriteLine(printNumSum);
//            }
//            if (printConsist == "Password must consist only of letters and digits")
//            {
//                Console.WriteLine(printConsist);
//            }
//            if (printMinDigits == "Password must have at least 2 digits")
//            {
//                Console.WriteLine(printMinDigits);
//            }

//        }
//        //Solution
//        //Must between 6 and 10 characters
//        static string NumberSumbol(string pass)
//        {
//            string result = "";

//            if (pass.Length >= 6 && pass.Length <= 10)
//            {
//                result = "true";
//            }
//            else
//            {
//                result = "Password must be between 6 and 10 characters";
//            }

//            return result;

//        }

//        //Must consist only of letters and digits
//        static string Consist(string pass)
//        {
//            string result = "";
//            int count = 0;

//            for (int i = 0; i < pass.Length; i++)
//            {
//                char character = pass[i];

//                if (character >= 60 && character <= 90
//                    || character >= 97 && character <= 122
//                    || character >= 48 && character <= 57)
//                {
//                    result = "true";
//                }
//                else if (count >= 0)
//                {
//                    result = "Password must consist only of letters and digits";
//                    break;
//                }
//            }

//            return result;
//        }

//        //Must have at least 2 digits
//        static string ContainsMinDigits(string pass)
//        {
//            int count = 0;
//            string result = "";
//            for (int i = 0; i < pass.Length; i++)
//            {
//                if (pass[i] >= 48 && pass[i] <= 57)
//                {
//                    count++;
//                    if (count >= 2)
//                    {
//                        result = "true";
//                    }

//                }
//                else
//                {
//                    result = "Password must have at least 2 digits";
//                }
//            }
//            return result;

//        }



//    }
////}
