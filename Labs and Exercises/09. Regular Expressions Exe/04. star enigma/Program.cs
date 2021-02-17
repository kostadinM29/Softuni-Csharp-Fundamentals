using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._star_enigma
{
    class Program
    {
        static void Main(string[] args)
        {

            string starPattern = @"[sStTaArR]";
            string decryptPattern = @"@(?<planet>[A-z]+)([^@\-!:>])*:(?<population>\d*)([^@\-!:>])*!(?<attackType>[AD])!([^@\-!:>])*->(?<soldierCount>\d*).*?";
            int count = int.Parse(Console.ReadLine());
            List<string> destroyed = new List<string>();
            List<string> attacked = new List<string>();
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                var matches = Regex.Matches(input, starPattern);
                char[] chars = input.ToCharArray();
                for (int j = 0; j < chars.Length; j++)
                {
                    int newChar = chars[j] - matches.Count;
                    chars[j] = (char)newChar;
                }
                string newInput = String.Concat(chars);
                var decryptedMatch = Regex.Match(newInput, decryptPattern);
                if (decryptedMatch.Success)
                {
                    if (decryptedMatch.Groups["attackType"].Value == "A")
                    {
                        attacked.Add(decryptedMatch.Groups["planet"].Value);
                    }
                    if (decryptedMatch.Groups["attackType"].Value == "D")
                    {
                        destroyed.Add(decryptedMatch.Groups["planet"].Value);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            if (attacked.Count > 0)
            {
                foreach (var item in attacked.OrderBy(a => a))
                {
                    Console.WriteLine($"-> {item}");
                }
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            if (destroyed.Count > 0)
            {
                foreach (var item in destroyed.OrderBy(a => a))
                {
                    Console.WriteLine($"-> {item}");
                }
            }
        }
    }
}
