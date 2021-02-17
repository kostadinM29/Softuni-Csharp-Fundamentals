using System;
using System.Collections.Generic;

namespace _02._miner_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                int quant = int.Parse(Console.ReadLine());
                if (!(resources.ContainsKey(resource)))
                {
                    resources.Add(resource, quant);
                }
                else
                {
                    resources[resource] += quant;
                }
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
