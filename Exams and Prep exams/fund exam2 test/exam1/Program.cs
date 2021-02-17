using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, PlantDetails> plants = new Dictionary<string, PlantDetails>();
            for (int i = 0; i < n; i++)
            {
                List<string> plantinput = Console.ReadLine().Split("<->").ToList();
                string name = plantinput[0];
                int rarity = int.Parse(plantinput[1]);
                PlantDetails plant = new PlantDetails();
                plant.rarity = rarity;
                plant.ratings = new List<int>();
                if (!(plants.ContainsKey(name)))
                {
                    plants.Add(name, plant);
                }
                else
                {
                    plants[name].rarity = rarity;
                }
            }
            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                if (command[0] == "Exhibition")
                {
                    break;
                }
                string name = command[1];
                switch (command[0])
                {
                    case "Rate:":
                        if (plants.ContainsKey(name))
                        {
                            plants[name].ratings.Add(int.Parse(command[3]));
                        }
                        break;
                    case "Update:":
                        if (plants.ContainsKey(name))
                        {
                            plants[name].rarity = int.Parse(command[3]);
                        }
                        break;
                    case "Reset:":
                        if (plants.ContainsKey(name))
                        {
                            plants[name].ratings = new List<int>();
                        }
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            Console.WriteLine("Plants for the exhibition:");
            List<FinalPlant> final = new List<FinalPlant>();
            foreach (var plant in plants)
            {
                FinalPlant fplant = new FinalPlant();

                fplant.name = plant.Key;
                fplant.rarity = plant.Value.rarity;
                if (plant.Value.ratings.Count == 0)
                {
                    fplant.ratingSum = 0;
                }
                else
                {
                    fplant.ratingSum = plant.Value.ratings.Average();
                }
                final.Add(fplant);
            }
            foreach (var plant in final.OrderByDescending(x => x.rarity).ThenByDescending(x => x.ratingSum))
            {
                Console.WriteLine($"- {plant.name}; Rarity: {plant.rarity}; Rating: {plant.ratingSum:f2}");
            }
        }
    }
    public class PlantDetails
    {
        public int rarity { get; set; }
        public List<int> ratings { get; set; }

    }
    public class FinalPlant
    {
        public string name { get; set; }
        public int rarity { get; set; }
        public double ratingSum { get; set; }
    }
}