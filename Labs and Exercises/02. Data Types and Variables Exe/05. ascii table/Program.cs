using System;
using System.Text;

namespace _05._ascii_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            for (int i = n; i <= y; i++)
            {
                string result = char.ConvertFromUtf32(i);
                Console.Write($"{result} ");
            }
        }
    }
}
