using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;

namespace _05._softuni_parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> plates = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                if (command[0] == "register")
                {
                    if (plates.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plates[command[1]]}");
                    }
                    else
                    {
                        plates.Add(command[1], command[2]);
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }
                }
                if (command[0] == "unregister")
                {
                    if (!(plates.ContainsKey(command[1])))
                    {
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    }
                    else
                    {
                        plates.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                }
            }
            foreach (var plate in plates)
            {
                Console.WriteLine($"{plate.Key} => {plate.Value}");
            }
        }
    }
}
