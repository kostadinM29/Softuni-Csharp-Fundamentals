using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._bar_income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)%.*?<(?<product>\w+)>.*?\|(?<count>\d+)\|.*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            double totalSum = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of shift")
                {
                    break;
                }
                var match = Regex.Match(input, pattern);
                if (match.Success)
                {

                    double sum = int.Parse(match.Groups["count"].Value) * double.Parse(match.Groups["price"].Value);
                    Console.WriteLine($"{match.Groups["customer"].Value}: {match.Groups["product"].Value} - {sum:f2}");
                    totalSum += sum;
                }
            }
            Console.WriteLine($"Total income: {totalSum:f2}");
        }
    }
}
