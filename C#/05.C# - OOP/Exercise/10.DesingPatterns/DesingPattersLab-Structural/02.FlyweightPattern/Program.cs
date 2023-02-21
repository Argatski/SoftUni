using _02.FlyweightPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        IPaymentSystem paymentSystem = new PaymentSystemDecorator(new PaypalSystem()); //->this is decorator

        paymentSystem.LoanMoney("Pesho", "Gosho", 22);
        paymentSystem.PayMoney("Pesho", "Gosho", 22555);
        paymentSystem.LoanMoney("Pesho", "Gosho", 56);

    }
}