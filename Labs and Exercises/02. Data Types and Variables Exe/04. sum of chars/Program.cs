using System;
using System.Text;

namespace _04._sum_of_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;
            for (int i = 1; i <=n; i++)
            {
                string input = Console.ReadLine();
                foreach (char c in input)
                {
                    totalSum += (int)c;
                }
            }
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
