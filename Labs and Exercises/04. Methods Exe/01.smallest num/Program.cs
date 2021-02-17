using System;

namespace _01.smallest_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowestInteger = LowestInteger();
            Console.WriteLine(lowestInteger);
        }

        static int LowestInteger()
        {
            int lowest = int.MaxValue;
            for (int i = 0; i < 3; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (lowest> n)
                {
                   lowest = n;
                }
            }
            return lowest;
        }
    }
}
