using System;

namespace _02._vowels_count
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = VowelCheck();
            Console.WriteLine(counter);
        }
        static int VowelCheck()
        {
            int counter = 0;
            string sentence = Console.ReadLine();
            char[] charArr = sentence.ToCharArray();
            foreach (char ch in charArr)
            {
                if (ch == 'a' || ch == 'e' || ch == 'y' || ch == 'o' || ch == 'u' || ch == 'i'|| ch == 'A' || ch == 'E' || ch == 'Y' || ch == 'O' || ch == 'U' || ch == 'I')
                {
                    counter += 1;
                }
            }
            return counter;
        }
    }
}
