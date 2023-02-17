using _04.AbstractFactoryPattern.Contracts;
using _04.AbstractFactoryPattern.Factories;

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