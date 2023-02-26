using _02.CompositePattern;

internal class Program
{
    private static void Main(string[] args)
    {
        var phone = new SingleGift("Test", 10);

        Console.WriteLine(phone.CalculateTotalPrice());

        var compositeGift = new Composite("Rootbox", 0);
        var singleGift = new SingleGift("qwow", 50);
        var singleGift2 = new SingleGift("qwow", 70);

        compositeGift.Add(singleGift);
        compositeGift.Add(singleGift2);
        Console.WriteLine(compositeGift.CalculateTotalPrice());

    }
}