using System;

namespace _04._print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputOne = int.Parse(Console.ReadLine());
            int inputTwo = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = inputOne; i <= inputTwo; i++)
            {
                if (i == inputTwo)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                else
                {
                    Console.Write(i + " ");
                    sum += i;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
