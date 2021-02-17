using System;

namespace _05._orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
                Calculations(product, n);
        }
        static void Calculations(string product, int numberOfProducts)
        {
            double sum = 0;
            for (int i = 1; i <= numberOfProducts; i++)
            {
                switch (product)
                {
                    case "coffee":
                        sum += 1.50;
                        break;
                    case "water":
                        sum += 1.00;
                        break;
                    case "coke":
                        sum += 1.40;
                        break;
                    case "snacks":
                        sum += 2.00;
                        break;
                }
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
