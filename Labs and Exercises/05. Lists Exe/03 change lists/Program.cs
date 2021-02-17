using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_change_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestCount = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < guestCount; i++)
            {
                List<string> input = ReadStringListSingleLine();
                string name = input[0];
                if (input.Count == 3)
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                else
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);

                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
                Console.WriteLine(string.Join(Environment.NewLine, guests));
        }
        static List<string> ReadStringListSingleLine()
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            return numbers;
        }
    }
}
