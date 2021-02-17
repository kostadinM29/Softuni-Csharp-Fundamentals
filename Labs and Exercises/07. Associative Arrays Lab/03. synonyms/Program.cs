using System;
using System.Collections.Generic;

namespace _03._synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string syn = Console.ReadLine();
                if (words.ContainsKey(word) == false)
                {
                    words.Add(word, new List<string>());
                }
                words[word].Add(syn);
            }
            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", words[word.Key])}");
            }
        }
    }
}
