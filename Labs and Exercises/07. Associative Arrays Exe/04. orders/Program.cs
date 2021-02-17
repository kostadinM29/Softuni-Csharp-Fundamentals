using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();
            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                string name = command[0];
                if (name == "buy")
                {
                    break;
                }
                double price = double.Parse(command[1]);
                int quant = int.Parse(command[2]);

                Product product = new Product(name, price, quant);
                if (!(products.ContainsKey(name)))
                {
                    products.Add(name, product);
                }
                else
                {
                    products[name].Price = price;
                    products[name].Quant += quant;
                }
            }
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value.Price * product.Value.Quant:f2}");
            }
        }
    }
    class Product
    {
        string name { get; set; }
        double price;
        int quant { get; set; }
        public Product(string name, double price, int quant)
        {
            this.name = name;
            this.price = price;
            this.quant = quant;
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int Quant
        {
            get
            {
                return quant;
            }
            set
            {
                quant = value;
            }
        }
    }
}
