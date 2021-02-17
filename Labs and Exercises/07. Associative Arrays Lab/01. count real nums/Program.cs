using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._count_real_nums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();
            foreach (int number in list)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts.Add(number, 1);
                }
            }
            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }

        }
    }
}
