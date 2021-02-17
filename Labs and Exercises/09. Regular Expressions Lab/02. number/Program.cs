using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._number
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\+359( |-)2(\1)([0-9]{3})(\1)([0-9]{4})\b");
            var phones = Console.ReadLine();
            var phoneMatches = regex.Matches(phones);

            var finalPhones = phoneMatches.Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToList();
            Console.WriteLine(string.Join(", ",finalPhones));
        }
    }
}
