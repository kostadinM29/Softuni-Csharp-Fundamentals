using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._word_filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().Where(x =>x.Length % 2 == 0).ToList();

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
