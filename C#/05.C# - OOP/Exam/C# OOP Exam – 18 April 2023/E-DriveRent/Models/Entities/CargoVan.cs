using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Models.Entities
{
    public class CargoVan : Vehicle
    {
        private const int _maxMileage = 180;
        public CargoVan(string brand, string model, string licensePlateNumber)
            : base(brand, model, _maxMileage, licensePlateNumber)
        {
        }
    }
}
