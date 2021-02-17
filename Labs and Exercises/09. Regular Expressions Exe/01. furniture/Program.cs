using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @">>(?<name>[A-z]+)<<(?<price>\d+\.?\d*)\!(?<quantity>\d+)";
            double totalMoney = 0;
            List<string> boughtFurni = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Purchase")
                {
                    break;
                }
                var matches = Regex.Match(input, regex);
                if (matches.Success)
                {
                    boughtFurni.Add(matches.Groups["name"].Value);
                    double price = double.Parse(matches.Groups["price"].Value);
                    double quantity = double.Parse(matches.Groups["quantity"].Value);
                    totalMoney += price * quantity;
                }
            }
            Console.WriteLine("Bought furniture:");
            if (boughtFurni.Count > 0)
            {
                foreach (var item in boughtFurni)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine($"Total money spend: {totalMoney}");
        }
    }
}
