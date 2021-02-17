using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._append_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> deckOne = ReadIntListSingleLine();
            List<int> deckTwo = ReadIntListSingleLine();
            while (deckOne.Count > 0 && deckTwo.Count > 0)
            {
                if (deckOne[0] > deckTwo[0])
                {
                    deckOne.Add(deckOne[0]);
                    deckOne.Add(deckTwo[0]);
                    deckTwo.RemoveAt(0);
                    deckOne.RemoveAt(0);
                }
                else if (deckOne[0] < deckTwo[0])
                {
                    deckTwo.Add(deckTwo[0]);
                    deckTwo.Add(deckOne[0]);
                    deckTwo.RemoveAt(0);
                    deckOne.RemoveAt(0);
                }
                else if (deckOne[0] == deckTwo[0])
                {
                    deckTwo.RemoveAt(0);
                    deckOne.RemoveAt(0);
                }
            }
            if (deckOne.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {deckTwo.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {deckOne.Sum()}");
            }
        }
        static List<int> ReadIntListSingleLine()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            return numbers;
        }
    }
}
