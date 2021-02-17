using System;

namespace _09._spice_must_flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int days = 0;
            int totalYield = 0;
            while (true)
            {
                if (yield < 100)
                {
                    totalYield -= 26;
                    if (totalYield < 0)
                    {
                        totalYield = 0;
                    }
                    break;
                }
                totalYield += yield;
                totalYield -= 26;
                if (totalYield < 0)
                {
                    totalYield = 0;
                }
                yield -= 10;
                days++;
            }
            Console.WriteLine(days);
            Console.WriteLine(totalYield);
        }
    }
}
