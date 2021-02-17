using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;

namespace _06._replace_repeating
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 1; i < input.Length; i++)
            {
                char previous = input[i - 1];
                char current = input[i];
                if (current == previous)
                {
                    input = input.Remove(i,1);
                    i--;
                }
            }
            Console.WriteLine(input);
        }
    }
}
