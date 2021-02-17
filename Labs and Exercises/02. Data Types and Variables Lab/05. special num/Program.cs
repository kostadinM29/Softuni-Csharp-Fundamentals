using System;
using System.Globalization;

namespace _05._special_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int num = i;
                int sum = 0;
                int tempNum = num;
                while (tempNum > 0)
                {
                    sum += tempNum % 10;
                    tempNum = tempNum / 10;
                }
                if (sum == 5 || sum == 7|| sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
