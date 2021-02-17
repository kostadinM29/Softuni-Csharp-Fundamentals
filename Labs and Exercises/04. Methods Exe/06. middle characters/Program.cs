using System;

namespace _06._middle_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PrintMiddleChar(text);
        }
        static void PrintMiddleChar(string text)
        {
            if (text.Length % 2 == 0)
            {
                Console.Write(text[(text.Length / 2) - 1]);
                Console.Write(text[text.Length / 2]);
            }
            else
            {
                Console.Write(text[((text.Length + 1) / 2) - 1]);
            }
        }
    }
}
