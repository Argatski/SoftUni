using System;
using System.Collections.Generic;
using System.Text;

namespace _07.VehicleCatalogue
{
    class Catalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

    }
}
