using System;

namespace multiplication_table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int inputTwo = int.Parse(Console.ReadLine());
            if (inputTwo > 10)
            {
                Console.WriteLine($"{input} X {inputTwo} = {input * inputTwo}");
            }
            for (int i = inputTwo; i <= 10; i++)
            {
                Console.WriteLine($"{input} X {i} = {input * i}");
            }

        }
    }
}
