using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = ReadIntListSingleLine();
            int capacity = int.Parse(Console.ReadLine());
            while (true)
            {
                List<string> input = ReadStringListSingleLine();
                if (input[0] == "end")
                {
                    break;
                }
                if (input[0] == "Add")
                {
                    train.Add(int.Parse(input[1]));
                }
                else
                {
                    int passengers = int.Parse(input[0]);
                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i]+ passengers <= capacity)
                        {
                            train[i] += passengers;
                            break;
                        }

                    }
                }
            }
            Console.WriteLine(string.Join(" ", train));

        }
        static List<int> ReadIntListSingleLine()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            return numbers;
        }
        static List<string> ReadStringListSingleLine()
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            return numbers;
        }
    }
}
