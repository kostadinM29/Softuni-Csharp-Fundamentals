using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._text_filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bannedWords = Console.ReadLine().Split(", ").ToList();
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Count; i++)
            {
                text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
            }
            Console.WriteLine(text);
        }
    }
}
