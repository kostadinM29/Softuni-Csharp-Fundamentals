using System;
using System.Globalization;

namespace _06._strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int sum = 0;
            int tempNum = int.Parse(num);
            for (int i = 0; i < num.Length; i++)
            {
                int currentDigit = tempNum % 10;
                tempNum = (tempNum - currentDigit) / 10;

                int factorial = 1;
                for (int j = 1; j <= currentDigit; j++)
                {
                    factorial *= j;
                }
                sum += factorial;
            }
            if (int.Parse(num) == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
