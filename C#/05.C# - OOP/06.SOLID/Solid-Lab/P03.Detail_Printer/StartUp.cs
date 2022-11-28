using System.Collections.Generic;

namespace P03.DetailPrinter
{
    public class StartUp
    {
        static void Main()
        {
            Employee first = new Employee("Pesho");
            Employee second = new Employee("Ivan");

            Manager manager = new Manager("Gosho", new List<string>() { "data.txt", "previev.pptx", "sallaries.xsl" });
            IList<Employee> employees = new List<Employee>()
            { first,second,manager};

            DetailsPrinter printer = new DetailsPrinter(employees);
            printer.PrintDetails();
        }
    }
}
