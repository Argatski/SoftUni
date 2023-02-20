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
        public ICarBuilder BuildEngine(Car car)
        {
            car.Engine = "Mercedes";
            return this;
        }

        public ICarBuilder BuildTransmission(Car car)
        {
            car.Transmission = "DCT";

            return this;
        }

        public ICarBuilder BuildTyres(Car car)
        {
            car.Tyres = "Michelin";
            return this;
        }
    }
}
