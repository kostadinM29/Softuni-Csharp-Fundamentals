using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._merging_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = ReadIntListSingleLine();
            List<int> numbers2 = ReadIntListSingleLine();

            List<int> resultNumbers = new List<int>();
            for (int i = 0; i < Math.Min(numbers1.Count, numbers2.Count); i++)
            {
               // if (i % 2 == 0 || i == 0)
                //{
                    resultNumbers.Add(numbers1[i]);
               // }
               // else
               // {
                    resultNumbers.Add(numbers2[i]);
                //}
            }
            if (numbers1.Count > numbers2.Count)
            {
                resultNumbers.AddRange(GetRemainingElements(numbers1, numbers2));
            }
            else if (numbers2.Count > numbers1.Count)
                resultNumbers.AddRange(GetRemainingElements(numbers2, numbers1));
            Console.WriteLine(string.Join(" ", resultNumbers));


        }
        static List<int> GetRemainingElements(List<int> longerlist, List<int> shorterlist)
        {
            List<int> numbers = new List<int>();
            for (int i = shorterlist.Count; i < longerlist.Count; i++)
            {
                numbers.Add(longerlist[i]);

            }
            return numbers;
        }
        static List<int> ReadIntListSingleLine()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            return numbers;
        }

    }
}
