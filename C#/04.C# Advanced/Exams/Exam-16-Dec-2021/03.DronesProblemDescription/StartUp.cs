using System;

namespace Drones
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Initialize the repository (Airfield)
            Airfield airfield = new Airfield("Heathrow", 10, 10.5);

            // Initialize entity
            Drone drone = new Drone("D20", "DEERC", 6);

            //Print Drone
            Console.WriteLine(drone);

            //Add Drone
            Console.WriteLine(airfield.AddDrone(drone));
            Console.WriteLine(airfield.Count);

            // Remove Drone
            Console.WriteLine(airfield.RemoveDrone("DE51"));

            //Initialize entity
            Drone secondDrone = new Drone("CW4", "Cheerwing", 8);
            Drone thirdDrone = new Drone("X5SW-V3", "Cheerwing", 7);
            Drone fourthDrone = new Drone("X20", "Cheerwing", 4);
            Drone fifthDrone = new Drone("EVO2", "Autel", 10);
            Drone sixtDrone = new Drone("XL5-6S-FPV", "iFlight", 10);

            // Add Drones
            Console.WriteLine(airfield.AddDrone(secondDrone));
            Console.WriteLine(airfield.AddDrone(thirdDrone));
            Console.WriteLine(airfield.AddDrone(fourthDrone)); // Invalid drone. 
            Console.WriteLine(airfield.AddDrone(fifthDrone));
            Console.WriteLine(airfield.AddDrone(sixtDrone));

            Console.WriteLine(airfield.Count);

            //Remove drone by brand
            Console.WriteLine(airfield.RemoveDroneByBrand("Cheeerwing"));

        }
    }
}
