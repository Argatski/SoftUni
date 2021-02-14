using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbRol = double.Parse(Console.ReadLine());
            var numbRolPlat = double.Parse(Console.ReadLine());
            var literLepilo = double.Parse(Console.ReadLine());
            var prarsent = double.Parse(Console.ReadLine());

            var polka = numbRol * 5.80;
            var roklkaplat = numbRolPlat * 7.20;
            var lepilo = literLepilo * 1.20;

            var allMaterials = polka + roklkaplat + lepilo;
            var pricePrarsent = allMaterials - ((allMaterials * prarsent) / 100);
            Console.WriteLine("{0:f3}",pricePrarsent);
        }
    }
}
