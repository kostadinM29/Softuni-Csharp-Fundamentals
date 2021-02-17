using System;
using System.Security.Cryptography;

namespace _05._login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = string.Empty, password = string.Empty;
            user = Console.ReadLine();
            for (int i = user.Length - 1; i >= 0; i--)
            {
                password += user[i];
            }
            int failcounter = 0;
            while (true)
            {
                string attempt = Console.ReadLine();
                if (attempt == password)
                {
                    Console.WriteLine($"User {user} logged in.");
                    break;
                }
                if (failcounter == 3)
                {
                    Console.WriteLine($"User {user} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                failcounter++;
            }
        }
    }
}
