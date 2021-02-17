using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._char_multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            Console.WriteLine(CharMultiplier(input[0], input[1]));
        }
        static int CharMultiplier (string first, string second)
        {
            int sum = 0;
            string longest = "";
            string shortest = "";
            if (first.Length > second.Length)
            {
                longest = first;
                shortest = second;
            }
            else
            {
                longest = second;
                shortest = first;
            }
            for (int i = 0; i < shortest.Length; i++)
            {
                sum += first[i] * second[i];
            }
            for (int i = shortest.Length; i < longest.Length; i++)
            {
                sum += longest[i];
            }
            return sum;
        }
    }
} 
