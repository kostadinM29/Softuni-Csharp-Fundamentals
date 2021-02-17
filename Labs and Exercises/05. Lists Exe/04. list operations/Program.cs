using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _04._list_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = ReadIntListSingleLine();
            while (true)
            {
                List<string> operation = ReadStringListSingleLine();

                if (operation[0] == "End")
                {
                    break;
                }
                if (operation[0] == "Add")
                {
                    int number = int.Parse(operation[1]);
                    list.Add(number);
                }
                if (operation[0] == "Insert")
                {
                    int numberToInsert = int.Parse(operation[1]);
                    int index = int.Parse(operation[2]);
                    if (index >= 0 && index < list.Count)
                    {
                        list.Insert(index, numberToInsert);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }

                }
                if (operation[0] == "Remove")
                {
                    int indexToRemove = int.Parse(operation[1]);
                    if (indexToRemove >= 0 && indexToRemove < list.Count)
                    {
                        list.RemoveAt(indexToRemove);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                if (operation[0] == "Shift")
                {
                    int count = int.Parse(operation[2]);
                    if (operation[1] == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int firstNum = list[0];
                            list.Add(firstNum);
                            list.RemoveAt(0);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int lastNum = list[list.Count - 1];
                            list.Insert(0, lastNum);
                            list.RemoveAt(list.Count - 1);
                        }
                    }
                }

            }
            Console.WriteLine(string.Join(" ",list));

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
