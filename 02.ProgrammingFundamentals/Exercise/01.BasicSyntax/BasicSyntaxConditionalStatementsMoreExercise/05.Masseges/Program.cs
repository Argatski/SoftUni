using System;

namespace _05.Masseges
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string messegas = string.Empty;

            for (int i = 1; i <= number; i++)
            {
                int commond = int.Parse(Console.ReadLine());

                switch (commond)
                {
                    case 2: messegas += "a"; break;
                    case 22: messegas += "b"; break;
                    case 222: messegas += "c"; break;
                    case 3: messegas += "d"; break;
                    case 33: messegas += "e"; break;
                    case 333: messegas += "f"; break;
                    case 4: messegas += "g"; break;
                    case 44: messegas += "h"; break;
                    case 444: messegas += "i"; break;
                    case 5: messegas += "j"; break;
                    case 55: messegas += "k"; break;
                    case 555: messegas += "l"; break;
                    case 6: messegas += "m"; break;
                    case 66: messegas += "n"; break;
                    case 666: messegas += "o"; break;
                    case 7: messegas += "p"; break;
                    case 77: messegas += "q"; break;
                    case 777: messegas += "r"; break;
                    case 7777: messegas += "s"; break;
                    case 8: messegas += "t"; break;
                    case 88: messegas += "u"; break;
                    case 888: messegas += "v"; break;
                    case 9: messegas += "w"; break;
                    case 99: messegas += "x"; break;
                    case 999: messegas += "y"; break;
                    case 9999: messegas += "z"; break;
                    case 0: messegas += " "; break;

                    default:
                        break;
                }

            }
            Console.WriteLine(messegas);
        }
    }
}
