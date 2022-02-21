using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        private List<Drone> Drones;

        //Properties
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }

        //Constructor
        public Airfield(string name, int capacity, double landingStrip)
        {
            Name = name;
            Capacity = capacity;
            LandingStrip = landingStrip;
            Drones = new List<Drone>();
        }

        /// <summary>
        /// Returns the count of the drones in the airfield.
        /// </summary>
        /// <param name="drone"></param>
        /// <returns></returns>
        public int Count { get; private set; }

        /// <summary>
        /// Adds a drone to the drone's collection if there is room for it.
        /// </summary>
        /// <param name="drone"></param>
        /// <returns></returns>
        public string AddDrone(Drone drone)
        {
            bool isValid = drone.Name == null && drone.Brand == null || drone.Range >= 5 && drone.Range <= 15;

            string result = "";

            if (isValid)
            {
                if (Capacity == Count)
                {
                    result = "Airfield is full.";
                }
                else
                {
                    Drones.Add(drone);
                    Count++;
                    result = $"Successfully added {drone.Name} to the airfield.";
                }

            }
            else if (isValid == false)
            {
                result = "Invalid drone.";
            }
            return result;
        }

        /// <summary>
        /// Removes a drone by given name, if such exists return true, otherwise false.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool RemoveDrone(string name)
        {
            foreach (var drone in Drones)
            {
                if (drone.Name == name)
                {
                    Drones.Remove(drone);
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Removes all drones by the given brand, if such exists, return how many drones were removed, otherwise 0.
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public int RemoveDroneByBrand(string brand)
        {
            int dronesRemoved = 0;

            /// Not work.

            for (int i = 0; i < Drones.Count(); i++)
            {
                if (Drones[i].Brand == brand)
                {
                    Drones.Remove(Drones[i]);
                    dronesRemoved++;
                    i--;
                }
            }

            return dronesRemoved;
        }

        /// <summary>
        /// Method – fly (set its available property to false without removing it from the collection) the drone with the given name if exists. As a result return the drone, or null if does not exist.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Drone FlyDrone(string name)
        {
            Drone flyDrone = null;
            foreach (var drone in Drones)
            {
                if (drone.Name == name)
                {
                    drone.Available = false;
                    flyDrone = drone;
                }
            }

            return flyDrone;
        }

        /// <summary>
        /// FlyDrones method - fly and returns all drones which have a range equal or bigger to the given. Return a list of all drones which have been flown. The range will always be valid.
        /// </summary>
        /// <param name="range"></param>
        /// <returns></returns>
        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> flyDrone = new List<Drone>();

            foreach (var drone in Drones)
            {
                if (drone.Range == range)
                {
                    flyDrone.Add(drone);
                    drone.Available = false;
                }
            }

            return flyDrone;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Drones available at {Name}:");
            foreach (var drone in Drones)
            {
                if (drone.Available == true)
                {
                    sb.AppendLine(drone.ToString());
                }
            }

            return sb.ToString();
        }
    }
}
