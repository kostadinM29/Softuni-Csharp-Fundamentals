using System;

namespace _08._math_power
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double result = MathPow(n1, n2);
            Console.WriteLine(result);
        }
        static double MathPow(double n1, double n2)
        {
            double result = 0d;
            result = Math.Pow(n1, n2);
            return result;
        }
    }
}
