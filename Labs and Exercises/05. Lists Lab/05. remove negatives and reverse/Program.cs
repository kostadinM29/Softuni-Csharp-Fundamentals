using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._remove_negatives_and_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = ReadIntListSingleLine();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i--);
                }
            }
            numbers.Reverse();
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
        static List<int> ReadIntListSingleLine()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            return numbers;
        }
    }
}
