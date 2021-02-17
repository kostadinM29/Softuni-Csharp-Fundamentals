using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string initial = Console.ReadLine();
            while (true)
            {
                List<string> input = Console.ReadLine().Split(new char[] { ' ', ':' }).ToList();
                //List<string> input = inputcommand[1].Split(':').ToList();

                if (input[0] == "Travel")
                {
                    break;
                }

                switch (input[0])
                {
                    case "Add":
                        int start = int.Parse(input[2]);
                        string str = input[3];
                        if (start <= initial.Length - 1)
                        {
                            initial = initial.Insert(start, str);
                        }
                        Console.WriteLine(initial);
                        break;
                    case "Remove":
                        int s = int.Parse(input[2]);
                        int e = int.Parse(input[3]);
                        if (s >= 0 && e <= initial.Length - 1)
                        {
                            initial = initial.Remove(s, (e - s)+1);
                        }
                        Console.WriteLine(initial);
                        break;
                    case "Switch":
                        string old = input[1];
                        string neww = input[2];
                        initial = initial.Replace(old, neww);
                        Console.WriteLine(initial);
                        break;
                }

            }
            Console.WriteLine($"Ready for world tour! Planned stops: {initial}");
        }
    }
}
