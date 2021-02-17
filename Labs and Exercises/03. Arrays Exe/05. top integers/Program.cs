using System;
using System.Linq;

namespace _05._top_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                bool isBest = true;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        isBest = false;
                        break;
                    }
                }
                if (isBest)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}
