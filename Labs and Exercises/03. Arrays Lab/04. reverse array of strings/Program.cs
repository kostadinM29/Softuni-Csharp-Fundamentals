using System;
using System.Linq;

namespace _04._reverse_array_of_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ').ToArray();
            string[] arr = new string[values.Length];
            for (int i = 0; i < values.Length / 2; i++)
            {
                var oldElement = values[i];
                values[i] = values[values.Length - 1 - i];
                values[values.Length - 1 - i] = oldElement;
            }
            Console.WriteLine(String.Join(" ",values));
        }
    }
}
