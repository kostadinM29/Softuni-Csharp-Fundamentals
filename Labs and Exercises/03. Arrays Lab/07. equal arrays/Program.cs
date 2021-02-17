using System;
using System.Linq;

namespace _07._equal_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            int[] numbersTwo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            bool isDifferent = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != numbersTwo[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isDifferent = true;
                    break;
                }
                else
                {
                    sum += numbers[i];
                }
            }
            if (!isDifferent)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
