using _06.BilderPattern;
using _06.BuilderPattern;

public class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car();

        CarBuilder carBuilder = new CarBuilder();

        carBuilder.BuildEngine(car);
        carBuilder.BuildTransmission(car);
        carBuilder.BuildTyres(car);

        Console.WriteLine(car.Engine + " " + car.Transmission + " " + car.Tyres);
    }
}