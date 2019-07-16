using System;
using System.Collections.Generic;
using System.Linq;


namespace EX_4_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            //List<Product> products = new List<Product>();
            string line = Console.ReadLine();
            while (line != "buy")
            {
                string[] command = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = command[0];
                double price = double.Parse(command[1]);
                int quantity = int.Parse(command[2]);

                if (!products.ContainsKey(name))
                {
                    products.Add(name, new Product(name, price, quantity));
                }
                else
                {
                    products[name].Price = price;
                    products[name].Quantity += quantity;
                }

                line = Console.ReadLine();
            }

            foreach (var item in products )
            {
                double total = item.Value.Price * item.Value.Quantity;
                Console.WriteLine($"{item.Key} -> {total:f2}");
            }

        }

    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

    }

}
