using System;

namespace _03._characters_in_range
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            PrintInRange(char1, char2);
        }
        static void PrintInRange(char start, char end)
        {
            if (start > end)
            {
                for (int i = end + 1; i < start; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = start + 1; i < end; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
