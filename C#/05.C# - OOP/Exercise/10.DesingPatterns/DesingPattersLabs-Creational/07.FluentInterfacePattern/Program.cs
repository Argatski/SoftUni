using _06.BilderPattern;
using _06.BuilderPattern;

public class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car();

        CarBuilder carBuilder = new CarBuilder();

        carBuilder.BuildEngine(car) //Chaining costructor
            .BuildTransmission(car)
            .BuildTyres(car);


        Console.WriteLine(car.Engine + " " + car.Transmission + " " + car.Tyres);
    }
}