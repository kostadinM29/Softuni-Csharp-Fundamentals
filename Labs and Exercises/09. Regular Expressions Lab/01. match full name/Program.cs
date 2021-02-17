using System;
using System.Text.RegularExpressions;

namespace _01._match_full_name
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b");
            string names = Console.ReadLine();

            MatchCollection matchedNames = regex.Matches(names);

            foreach (var item in matchedNames)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
