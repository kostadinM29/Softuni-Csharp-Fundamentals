using System;

namespace _08._beer_kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float biggestVolume = float.MinValue;
            string biggestKeg = "";
            for (int i = 1; i <=n; i++)
            {
                string keg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                float volume = (float)(Math.PI * Math.Pow(radius, 2) * height);
                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKeg = keg;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
