using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._legend_farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMats = new Dictionary<string, int>();
            Dictionary<string, int> junkMats = new Dictionary<string, int>();
            keyMats["motes"] = 0;
            keyMats.Add("fragments", 0);
            keyMats.Add("shards", 0);
            bool legendaryAquired = false;
            while (!legendaryAquired)
            {
                List<string> farm = Console.ReadLine().Split().ToList();
                for (int i = 0; i < farm.Count; i += 2)
                {
                    int quant = int.Parse(farm[i]);
                    string resource = farm[i + 1].ToLower();

                    if (resource == "shards" || resource == "fragments" || resource == "motes")
                    {
                        keyMats[resource] += quant;
                        if (keyMats[resource] >= 250)
                        {
                            keyMats[resource] -= 250;
                            if (resource == "shards")
                            {
                                Console.WriteLine($"Shadowmourne obtained!");
                            }
                            else if (resource == "fragments")
                            {
                                Console.WriteLine($"Valanyr obtained!");
                            }
                            else
                            {
                                Console.WriteLine($"Dragonwrath obtained!");
                            }
                            legendaryAquired = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!(junkMats.ContainsKey(resource)))
                        {
                            junkMats[resource] = 0;
                        }
                        junkMats[resource] += quant;
                    }
                }
            }
            Dictionary<string, int> filteredKeyMats = keyMats.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(a => a.Key, a => a.Value);
            foreach (var item in filteredKeyMats)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junkMats.OrderBy(x =>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
