using System;

namespace _07._water_overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tankWeigth = 0;
            for (int i = 1; i <= n; i++)
            {
                int litres = int.Parse(Console.ReadLine());
                if (tankWeigth + litres > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    litres = 0;
                }
                    tankWeigth += litres;
            }
            Console.WriteLine(tankWeigth);
        }
    }
}
