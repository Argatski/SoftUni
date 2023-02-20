using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BuilderPattern
{
    public interface ICarBuilder
    {
        ICarBuilder BuildTyres(Car car);
        //here is a difference in builder pattern is (void or diff) in fluent interface (ICarbuilder or another interface)

        ICarBuilder BuildEngine(Car car);

        ICarBuilder BuildTransmission(Car car);
    }
}
