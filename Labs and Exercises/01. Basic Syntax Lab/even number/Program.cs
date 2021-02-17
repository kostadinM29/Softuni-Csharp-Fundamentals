using System;

namespace even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            bool numberfound = false;
            while (!numberfound)
            {
                int input = int.Parse(Console.ReadLine());
                if (input % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(input)}");
                    numberfound = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
                
            }
        }
    }
}
