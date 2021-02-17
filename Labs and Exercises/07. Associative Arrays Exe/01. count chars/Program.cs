using System;
using System.Collections.Generic;

namespace _01._count_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char item in input)
            {
                if (item == ' ')
                {
                    continue;
                }
                if (!(dict.ContainsKey(item)))
                {
                    dict.Add(item, 1);
                }
                else
                {
                    dict[item]++;
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
