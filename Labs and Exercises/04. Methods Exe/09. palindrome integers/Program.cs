using System;
using System.Linq;

namespace _09._palindrome_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                if (IsIntegerPalindrome(input))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

            }
        }

        private static bool IsIntegerPalindrome(string num)
        {
            int[] array = num.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            if (array.Length % 2 == 0)
            {
                for (int i = 0; i < (array.Length / 2); i++)
                {
                    if (array[i] != array[array.Length - 1 - i])
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                for (int i = 0; i < array.Length + 1 / 2; i++)
                {
                    if (array[i] != array[array.Length - 1 - i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
