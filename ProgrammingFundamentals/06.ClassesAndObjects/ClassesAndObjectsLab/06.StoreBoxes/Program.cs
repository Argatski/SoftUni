using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (product != "end")
            {
                string[] listProduct = product.Split(" ");

                string serial = listProduct[0];
                string name = listProduct[1];
                int quantity = int.Parse(listProduct[2]);
                decimal price = decimal.Parse(listProduct[3]);

                Box box = new Box();
                box.SerialNumber = serial;
                box.ItemQuantity = quantity;
                box.ItemPrice = price;
                box.Item.Name = name;
                box.Item.Price = price * quantity;

                boxes.Add(box);

                product = Console.ReadLine();
            }

            List<Box> result = boxes.OrderByDescending(b => b.Item.Price).ToList();

            foreach (Box box in result)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.ItemPrice:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.Item.Price:f2}");
            }
        }
    }
}
