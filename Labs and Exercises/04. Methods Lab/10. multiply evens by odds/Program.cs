using System;

namespace _10._multiply_evens_by_odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            Console.WriteLine(MultiplyEventAndOddDigits(n));
        }

        static int MultiplyEventAndOddDigits(int n)
        {
            return CalculateDigitsSum(n, 0) * CalculateDigitsSum(n, 1);
        }

        static int CalculateDigitsSum(int n, int isOdd)
        {
            string number = n.ToString();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int currentDigit = int.Parse(number[i].ToString());
                if (currentDigit % 2 == isOdd)
                {
                    sum += currentDigit;
                }
            }

            return sum;
        }
    }
}
