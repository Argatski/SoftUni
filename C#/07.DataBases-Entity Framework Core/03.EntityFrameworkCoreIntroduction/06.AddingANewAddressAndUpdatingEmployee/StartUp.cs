namespace SoftUni
{
    using System;
    using System.Linq;
    using System.Text;

    using SoftUni.Data;
    using SoftUni.Models;

    public class StartUp
    {
        public static void Main()
        {
            using (SoftUniContext context =  new SoftUniContext())
            {
                string result = AddNewAddressToEmployee(context);

                Console.WriteLine(result);
            }  
        }

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            var str =  new StringBuilder();

            var addres = new Address
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            var emp = context.Employees.FirstOrDefault(e => e.LastName == "Nakov");

            addres.Employees.Add(emp);
            emp.Address = addres;

            context.SaveChanges();

            var empAddress = context.Employees
                .OrderByDescending(e=>e.AddressId)
                .Select(e=>e.Address.AddressText)
                .Take(10)
                .ToList();

            foreach (var e  in empAddress)
            {
                str.AppendLine($"{e}");
            }

            return str.ToString().TrimEnd();
        }
    }
}