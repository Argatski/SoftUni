using _06.BuilderPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BilderPattern
{
    internal class CarBuilder : ICarBuilder
    {
        public void BuildEngine(Car car)
        {
            car.Engine = "Mercedes";
        }

        public void BuildTransmission(Car car)
        {
            car.Transmission = "DCT";
        }

        public void BuildTyres(Car car)
        {
            car.Tyres = "Michelin";
        }
    }
}
