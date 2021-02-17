using System;

namespace _03._exact_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            decimal finalNum = 0;
            for (int i = 1; i <= input; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                finalNum += num;
            }
            Console.WriteLine(finalNum);
        }
    }
}
