using System;

namespace _08._factorial_division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            decimal result = DivideTwoNums(FactorialNumber(n1), FactorialNumber(n2));
            Console.WriteLine($"{result:f2}");
        }
        static decimal FactorialNumber(int n)
        {
            decimal factorialNum = 1;
            for (int i = n; i > 0; i--)
            {
                factorialNum *= i;
            }
            return factorialNum;
        }
        static decimal DivideTwoNums(decimal num1,decimal num2)
        {
            decimal result = num1 / num2;
            return result;
        }
    }
}
