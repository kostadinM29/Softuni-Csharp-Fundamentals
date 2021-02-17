using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._store_boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> itemList = new List<Item>();
            List<Box> boxList = new List<Box>();
            int number = int.MinValue;
            while (true)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                if (input[0] == "end")
                {
                    break;
                }
                Item item = new Item();
                item.itemName = input[1];
                item.itemPrice = double.Parse(input[3]);
                Box box = new Box();
                box.serialNum = int.Parse(input[0]);
                box.boxItem = item;
                box.itemQuant = int.Parse(input[2]);
                box.boxPrice = double.Parse(input[2]) * double.Parse(input[3]);


                itemList.Add(item);
                boxList.Add(box);

            }
            List<Box> sortedBox = boxList.OrderByDescending(b => b.boxPrice).ToList();
            foreach (Box box in sortedBox)
            {
                Console.WriteLine($"{box.serialNum}");
                Console.WriteLine($"-- {box.boxItem.itemName} - ${box.boxItem.itemPrice:f2}: {box.itemQuant}");
                Console.WriteLine($"-- ${box.boxPrice:f2}");
            }
        }
    }
     public class Item
    {
        public string itemName { get; set; }
        public double itemPrice { get; set; }
    }
    class Box
    {
        public int serialNum { get; set; }
        public Item boxItem { get; set; }
        public int itemQuant { get; set; }
        public double boxPrice { get; set; }
    }
}
