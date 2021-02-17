using System;

namespace _0._1_ad
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            Random rnd = new Random();
            for (int i = 1; i <= number; i++)
            {
                int rndPhr = rnd.Next(0, 6);
                int rndEve = rnd.Next(0, 6);
                int rndAut = rnd.Next(0, 8);
                int rndCit = rnd.Next(0, 5);
                Console.WriteLine($"{phrases[rndPhr]} {events[rndEve]} {authors[rndAut]} – {cities[rndCit]}");
            }
        }
    }
}
