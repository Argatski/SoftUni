namespace SoftUni
{
    using System;
    using System.Linq;
    using System.Text;

    using SoftUni.Data;

    public class StartUp
    {
        public static void Main()
        {
            using (var context = new SoftUniContext())
            {
                string result = GetAddressesByTown(context);
                Console.WriteLine(result);
            }
        }

        public static string GetAddressesByTown(SoftUniContext context)
        {
            var stb = new StringBuilder();

            var addreses = context.Addresses
                .Select
                (
                   a => new { a.AddressText, TownName = a.Town.Name, count = a.Employees.Count }
                ).OrderByDescending(c=>c.count).ThenBy(c=>c.TownName).ThenBy(c=>c.AddressText);


            foreach ( var address in addreses )
            {
                stb.AppendLine($"{address.AddressText}, {address.TownName} - {address.count} employees");
            }

            return stb.ToString().TrimEnd();
        }
    }
}