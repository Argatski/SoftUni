using _02.CommandPattern;
using _02.CommandPattern.Commands;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        while (true)
        {
            string[] input = Console.ReadLine().Split();

            int value = int.Parse(input[1]);

            ICommand command = null;

            switch (input[0])
            {
                case "+":
                    command = new PlusCommand(value);
                    break;
                case "*":
                    command = new MultiplyCommand(value);
                    break;
                case "-":
                    command = new MinusCommand(value);
                    break;
                case "undo":
                    calculator.Undo(value);
                    break;
                case "Redo":
                    calculator.Redo(value);
                    break;

            }
            if (command != null)
            {
                calculator.AddCommand(command);
            }

            Console.WriteLine(calculator.Result);
        }


    }
}