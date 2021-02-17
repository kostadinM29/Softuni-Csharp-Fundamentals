using System;

namespace _02._division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int divisibleNumber = 0;
            if (number % 2 == 0)
            {
                divisibleNumber = 2;
            }
            if (number % 3 == 0)
            {
                divisibleNumber = 3;
            }
            if (number % 6 == 0)
            {
                divisibleNumber = 6;
            }
            if (number % 7 == 0)
            {
                divisibleNumber = 7;
            }
            if (number % 10 == 0)
            {
                divisibleNumber = 10;
            }
            if (divisibleNumber == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {divisibleNumber}");
            }


        }
    }
}
