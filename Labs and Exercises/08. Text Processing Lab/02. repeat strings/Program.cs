using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._repeat_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            StringBuilder result = new StringBuilder();

            foreach (var word in list)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result.Append(word);
                }
            }
            Console.WriteLine(result);
        }
    }
}
