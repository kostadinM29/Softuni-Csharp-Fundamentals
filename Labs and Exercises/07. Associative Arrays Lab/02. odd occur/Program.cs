using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._odd_occur
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in list)
            {
                string lowerCaseWord = word.ToLower();
                if (counts.ContainsKey(lowerCaseWord))
                {
                    counts[lowerCaseWord]++;
                }
                else
                {
                    counts.Add(lowerCaseWord, 1);
                }
            }
            foreach (var count in counts)
            {
                if (!(count.Value % 2 == 0))
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
