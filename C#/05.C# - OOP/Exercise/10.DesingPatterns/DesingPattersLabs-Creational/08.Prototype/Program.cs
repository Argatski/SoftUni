using _08.Prototype;
using System.Runtime.Loader;

internal class Program
{
    private static void Main(string[] args)
    {
        Country country = new Country() { Name = "Bulgaria" };
        City city = new City() { Name = "Sofiq" };

        Address address = new Address() { Street = "Simeonovsko shose" };

        address.City = city;
        address.Country = country;

        Address prototypeAddres = (Address)address.Clone();
        prototypeAddres.Street = "bul.Bulgaria";

        prototypeAddres.City.Name = "Smolqn";


        Console.WriteLine(address);
        Console.WriteLine(prototypeAddres);
    }
}