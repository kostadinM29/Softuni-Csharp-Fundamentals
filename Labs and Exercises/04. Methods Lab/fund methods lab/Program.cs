using System;

namespace fund_methods_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNum(int.Parse(Console.ReadLine()));
        }
        static void PrintNum(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
