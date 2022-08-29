using System;
using System.Collections.Generic;

namespace Renovators
{
    public class StartUp
    {
        static void Main()
        {
            //Initialize the repository (Catalog)
            Catalog catalog = new Catalog("Quality renovators", 5, "Kitchen");

            //Initialize entity
            Renovator renovator = new Renovator("Gosho", "Painter", 270, 7);

            //Print Renovator
            Console.WriteLine(renovator);

            //Add Renovator
            Console.WriteLine(catalog.AddRenovator(renovator));

            //Count catalog
            Console.WriteLine(catalog.Count);

            //Remove Renovator
            Console.WriteLine(catalog.RemoveRenovator("Pesho"));

            //Initialize entity
            Renovator secondRenovator = new Renovator("Pesho", "Tiles", 200, 9);
            Renovator thirdRenovator = new Renovator("Ivan", "Tiles", 450, 7);
            Renovator fourthRenovator = new Renovator("Velichko", "Painter", 120, 3);
            Renovator fifthRenovator = new Renovator("Stamat", "Furniture", 300, 4);
            Renovator sixthRenovator = new Renovator("Genadi", "Furniture", 80, 15);
            Renovator seventhRenovator = new Renovator("Unufri", "Furniture", 80, 15);
            //Renovator eightRenovator = new Renovator("Stama", null, 80, 15);

            //Adds Renovators
            Console.WriteLine(catalog.AddRenovator(secondRenovator));
            Console.WriteLine(catalog.AddRenovator(thirdRenovator));
            Console.WriteLine(catalog.AddRenovator(fourthRenovator));
            Console.WriteLine(catalog.AddRenovator(fifthRenovator));
            Console.WriteLine(catalog.AddRenovator(sixthRenovator));
            Console.WriteLine(catalog.AddRenovator(seventhRenovator));
            //Console.WriteLine(catalog.AddRenovator(eightRenovator));

            // Hire renovator by name
            Console.WriteLine(catalog.HireRenovator("Genadi"));

            //Console.WriteLine(catalog.HireRenovator("Genadiii"));// Maybe is not correct

            //Pay renovators
            List<Renovator> renovators = catalog.PayRenovators(8);

            foreach (var renovatorsToBePaid in renovators)
            {
                Console.WriteLine(renovatorsToBePaid);
            }

            //Remove renovators by specialty
            Console.WriteLine(catalog.RemoveRenovatorBySpecialty("Painter"));

            Console.WriteLine("----------------------Report----------------------");
            Console.WriteLine(catalog.Report());

        }
    }
}
