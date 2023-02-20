using _09.LazyInitialization;

public class Program
{
    private static void Main(string[] args)
    {
        Lazy<Cart> cart = new Lazy<Cart>(() =>  new Cart(" Startting yea"));

        Console.WriteLine("In main");

        cart.Value.Balance = 50;
        Console.WriteLine(cart.Value.Balance);
    }
}