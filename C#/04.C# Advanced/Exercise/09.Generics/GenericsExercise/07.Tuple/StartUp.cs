using System;

namespace Tuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Input first line
            var input = Console.ReadLine().Split();
            string name = input[0] + " " + input[1];
            string address = input[2];

            //Instance
            Tuple<string, string> tuple = new Tuple<string, string>(name, address);
            //Print
            Console.WriteLine(tuple);

            //Input second line
            input = Console.ReadLine().Split();
            name = input[0];
            int litersBeer = (int.Parse)(input[1]);

            //Instance
            var tuple1 = new Tuple<string, int>(name, litersBeer);
            //Print
            Console.WriteLine(tuple1);

            //Input last line
            input = Console.ReadLine().Split();
            int  integerNum = int.Parse(input[0]);
            double doubleNum = double.Parse(input[1]);

            //Instance
            var tuple2 = new Tuple<int, double>(integerNum, doubleNum);
            //Print
            Console.WriteLine(tuple2);

        }
    }
}
