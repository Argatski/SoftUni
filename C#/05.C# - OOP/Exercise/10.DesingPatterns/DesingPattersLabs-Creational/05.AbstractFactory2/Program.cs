using _05.AbstractFactory2.Contracts;
using _05.AbstractFactory2.Factories;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Are you an apple Fangirl.");
        //yes

        var isFangirl = Console.ReadLine() == "yes" ? true : false;

        ITechnologyAbstractFactory technologyAbstractFactory = null;

        if (isFangirl)
        {
            technologyAbstractFactory = new AppleFactory();
        }
        else
        {
            technologyAbstractFactory = new SamsungFactory();
        }

        IMobilePhone myPhone = technologyAbstractFactory.CreatePhone();
        ITablet myTablet = technologyAbstractFactory.CreateTable();

        Console.WriteLine(myPhone.GetType().Name);
        Console.WriteLine(myTablet.GetType().Name);
    }
}