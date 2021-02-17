using System;

namespace _05._digits_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string numbers = "";
            string letters = "";
            string symbols = "";
            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if (char.IsDigit(ch))
                {
                    numbers += ch;
                }
                if (char.IsLetter(ch))
                {
                    letters += ch;
                }
                if (!(char.IsLetter(ch)) && !(char.IsDigit(ch)))
                {
                    symbols += ch;
                }
            }
            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}
