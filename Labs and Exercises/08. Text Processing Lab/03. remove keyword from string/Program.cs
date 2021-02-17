using System;

namespace _03._remove_keyword_from_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine().ToLower();
            string command = Console.ReadLine().ToLower();
            int index = command.IndexOf(keyword);
            while (index >= 0)
            {
                    command = command.Remove(index, keyword.Length);
                    index = command.IndexOf(keyword);
            }
            Console.WriteLine(command);
        }
    }
}
