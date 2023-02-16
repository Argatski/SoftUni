using _02.SimpleFactoryPattern;

public class Program
{
    private static void Main(string[] args)
    {
        IAnimal lion = AnimalFactory.CreateAnima("Lion");
        Console.WriteLine(lion.Name);

        IAnimal cat = AnimalFactory.CreateAnima("Cat");
        Console.WriteLine(cat.Name);
    }
}