using System;

namespace _05._add_and_subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = int.Parse(Console.ReadLine());
            int Num2 = int.Parse(Console.ReadLine());
            int Num3 = int.Parse(Console.ReadLine());

            int SumOf1And2 = Sum(Num1, Num2);
            Console.WriteLine(Subtract(Num3,SumOf1And2));
        }
        static int Sum(int Num1, int Num2)
        {
            int sum = Num1 + Num2;
            return sum;
        }
        static int Subtract(int Num3, int Sum)
        {
            int result = Sum - Num3;
            return result;
        }
    }

}
