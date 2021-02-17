using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> racers = new Dictionary<string, int>();
            List<string> racersString = Console.ReadLine().Split(", ").ToList();

            string namePattern = @"[A-Za-z]";
            string digitPattern = @"\d";
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of race")
                {
                    break;
                }

                var nameMatch = String.Concat(Regex.Matches(input, namePattern));
                var kmMatch = Regex.Matches(input, digitPattern);
                var sum = kmMatch.Select(x => int.Parse(x.Value)).Sum();
                if (racersString.Contains(nameMatch))
                {
                    if (!(racers.ContainsKey(nameMatch)))
                    {
                        racers.Add(nameMatch, 0);
                    }
                    racers[nameMatch] += sum;
                }
            }
            var sorted = racers.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
            Console.WriteLine($"1st place: {sorted[0]}");
            if (sorted.Count > 1)
            {
                Console.WriteLine($"2nd place: {sorted[1]}");
            }
            if (sorted.Count > 2)
            {
                Console.WriteLine($"3rd place: {sorted[2]}");
            }
        }
    }
}
