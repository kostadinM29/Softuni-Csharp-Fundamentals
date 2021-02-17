using System;
using System.Numerics;

namespace _11._snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            BigInteger biggestSnowballValue = 0;
            short bestSnow = 0;
            short bestTime = 0;
            short bestQual = 0;
            for (byte i = 1; i <= n; i++)
            {
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                short snowballQuality = short.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                if (snowballValue > biggestSnowballValue)
                {
                    biggestSnowballValue = snowballValue;
                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                    bestQual = snowballQuality;
                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {biggestSnowballValue} ({bestQual})");
        }
    }
}
