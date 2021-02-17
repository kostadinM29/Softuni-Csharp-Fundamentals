using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._change_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = ReadIntListSingleLine();

            while (true)
            {
                List<string> input = ReadStringListSingleLine();
                if (input[0] == "end")
                {
                    break;
                }
                if (input[0] == "Delete")
                {
                    int number = int.Parse(input[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == number)
                        {
                            numbers.RemoveAt(i);
                        }
                    }
                }
                if (input[0] == "Insert")
                {
                    int index = int.Parse(input[2]);
                    int number = int.Parse(input[1]);
                    numbers.Insert(index, number);
                }

            }
            Console.WriteLine(string.Join(" ", numbers));
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

