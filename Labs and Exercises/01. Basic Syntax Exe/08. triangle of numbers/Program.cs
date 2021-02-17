using System;
using System.Diagnostics.Tracing;

namespace _08._triangle_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                int counter = 0;
                while (counter == i)
                {
                    Console.Write(i + " ");
                    counter++;
                }
                Console.WriteLine("");
            }
        }
    }
}
