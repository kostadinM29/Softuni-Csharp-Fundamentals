using System;

namespace _03._calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    add(a,b);
                    break;
                case "multiply":
                    multiply(a, b);
                    break;
                case "subtract":
                    subtract(a, b);
                    break;
                case "divide":
                    divide(a, b);
                    break;
            }
        }
        static void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
