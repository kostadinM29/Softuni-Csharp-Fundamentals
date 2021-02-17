using System;

namespace _02._pound_to_dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            float input = float.Parse(Console.ReadLine());
            float calc = input * 1.31f;
            Console.WriteLine($"{calc:f3}");
        }
    }
}
