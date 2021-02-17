using System;

namespace _7._repeat_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = RepeatString(str, n);
            Console.WriteLine(result);
        }
        static string RepeatString (string str, int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result = string.Concat(str+result);
            }
            return result;
        }
    }
}
