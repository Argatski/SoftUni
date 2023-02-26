using _01.Prototype;

internal class Program
{
    private static void Main(string[] args)
    {
        Drink drink = new Drink("Cola");

        Sandwich sandwich = new Sandwich("Bb", "Cc", "Mm", "Veg", drink);
        Sandwich sandwich2 = sandwich.ShalloClone();
        Sandwich sandwich3 = sandwich.DeepClone();

        Console.WriteLine($"Original Object:");
        Console.WriteLine(sandwich);
        Console.WriteLine();

        Console.WriteLine($"Shallow Object:");
        Console.WriteLine(sandwich2);
        Console.WriteLine();


        Console.WriteLine($"Deep Object:");
        Console.WriteLine(sandwich3);

        sandwich.Bread = "123";
        sandwich.Chease = "1234";
        sandwich.Meat = "12345";
        sandwich.Veggies = "12345";
        sandwich.Drink.Name = "Pepsi";


        Console.WriteLine();

        Console.WriteLine($"Original Object:");
        Console.WriteLine(sandwich);
        Console.WriteLine();

        Console.WriteLine($"Shallow Object:");
        Console.WriteLine(sandwich2);
        Console.WriteLine();


        Console.WriteLine($"Deep Object:");
        Console.WriteLine(sandwich3);
    }
}