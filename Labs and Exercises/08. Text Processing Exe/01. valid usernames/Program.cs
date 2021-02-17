using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._valid_usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var username in usernames)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool Valid = ValidUserNames(username);
                    if (Valid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
        private static bool ValidUserNames(string user)
        {
            foreach (var symbol in user)
            {
                if (char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
