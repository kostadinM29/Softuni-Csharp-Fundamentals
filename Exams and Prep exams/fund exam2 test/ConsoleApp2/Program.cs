using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([=\/])(?<destination>[A-Z][A-z]{2,})(\1)";
            string input = Console.ReadLine();
            int count = 0;
            MatchCollection matches = Regex.Matches(input, pattern);
            List<string> destinations = new List<string>();
            foreach (Match match in matches)
            {
                string destination = match.Groups["destination"].Value;
                count += destination.Length;
                destinations.Add(destination);
            }
            Console.WriteLine("Destinations: " + string.Join(", ", destinations));
            Console.WriteLine($"Travel Points: {count}");
        }
    }
}
