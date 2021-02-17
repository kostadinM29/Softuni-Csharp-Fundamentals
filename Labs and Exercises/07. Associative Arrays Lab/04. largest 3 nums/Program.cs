using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._largest_3_nums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> sortedNums = numbers.OrderByDescending(n => n).ToList();
            for (int i = 0; i < sortedNums.Count; i++)
            {
                if (i == 3)
                {
                    break;
                }
                Console.Write(sortedNums[i] + " ");
            }
        }
    }
}
