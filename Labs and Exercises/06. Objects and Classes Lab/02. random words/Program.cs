using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._random_words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            Random rnd = new Random();
            for (int i = 0; i < list.Count; i++)
            {
                int rndPos = rnd.Next(0, list.Count-1);
                string temp = list[i];
                list[i] = list[rndPos];
                list[rndPos] = temp;
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "\n");
            }
        }
    }
}
