using _03.FactoryMethodPattern.Contracts;
using _03.FactoryMethodPattern.Factories;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Which continet do you wanna  play?");
        
        string continent =  Console.ReadLine();

        IAnimalFactory factory = new EuroFactory(); 

        if (continent == "Africa")
        {
            factory= new AfricanFactory();
        }
        

        ICarnivore animal =  factory.GetCarnivore();

        Console.WriteLine(animal.AnimalsThatEat);
    }
}