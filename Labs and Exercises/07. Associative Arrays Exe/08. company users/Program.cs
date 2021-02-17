using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _08._company_users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> Database = new Dictionary<string, List<string>>();
            while (true)
            {
                List<string> command = Console.ReadLine().Split(" -> ").ToList();
                if (command[0] == "End")
                {
                    break;
                }
                if (!(Database.ContainsKey(command[0])))
                {
                    Database.Add(command[0], new List<string>());
                }
                if (!Database[command[0]].Contains(command[1]))
                {
                    Database[command[0]].Add(command[1]);
                }
            }
            foreach (var company in Database.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{company.Key}");
                for (int i = 0; i < company.Value.Count; i++)
                {
                    Console.WriteLine($"-- {company.Value[i]}");
                }
            }
        }
    }
}
