using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._append_arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> numbers = Console.ReadLine().Split('|').ToList();
            for (int i = numbers.Count-1; i >= 0; i--)
            {
                List<string> list = numbers[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int j = 0; j < list.Count; j++)
                {
                    Console.Write($"{list[j]} ");
                }
            }

        }
    }
}
