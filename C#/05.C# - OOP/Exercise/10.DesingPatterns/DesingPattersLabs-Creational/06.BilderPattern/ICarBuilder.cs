using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BuilderPattern
{
    public interface ICarBuilder
    {
        void BuildTyres(Car car);

        void BuildEngine(Car car);

        void BuildTransmission(Car car);
    }
}
