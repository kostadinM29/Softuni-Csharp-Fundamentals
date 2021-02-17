using System;
using System.Globalization;
using System.Linq;

namespace _11._array_manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string input = String.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] method = input.Split();
                if (method[0] == "exchange")
                {
                    int index = int.Parse(method[1]);
                    if (index < 0 || index > numbers.Length - 1)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    Exchange(index, numbers);
                }
                else if (method[0] == "max")
                {
                    if (method[1] == "even")
                    {
                        MaxEven(numbers);
                    }
                    else
                    {
                        MaxOdd(numbers);
                    }
                }
                else if (method[0] == "min")
                {
                    if (method[1] == "even")
                    {
                        MinEven(numbers);
                    }
                    else
                    {
                        MinOdd(numbers);
                    }
                }
                else if (method[0] == "first")
                {
                    if (method[2] == "even")
                    {
                        int count = int.Parse(method[1]);
                        FirstEven(numbers, count);
                    }
                    else
                    {
                        int count = int.Parse(method[1]);
                        FirstOdd(numbers, count);
                    }
                }
                else if (method[0] == "last")
                {
                    if (method[2] == "even")
                    {
                        int count = int.Parse(method[1]);
                        LastEven(numbers, count);
                    }
                    else
                    {
                        int count = int.Parse(method[1]);
                        LastOdd(numbers, count);
                    }
                }
            }
            Console.WriteLine("[" + String.Join(", ", numbers) + "]");
        }
        static void Exchange(int index, int[] numbers)
        {
            
            int[] firstArray = new int[numbers.Length - index - 1];
            int[] secondArray = new int[index + 1];

            int firstArrCounter = 0;
            for (int i = index + 1; i < numbers.Length; i++)
            {
                firstArray[firstArrCounter] = numbers[i];
                firstArrCounter++;
            }

            for (int i = 0; i < index + 1; i++)
            {
                secondArray[i] = numbers[i];
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                numbers[i] = firstArray[i];
            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                numbers[firstArray.Length + i] = secondArray[i];
            }
        }
        static void MaxEven(int[] numbers)
        {
            int maxEven = int.MinValue;
            int index = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (numbers[i] >= maxEven)
                    {
                        maxEven = numbers[i];
                        index = i;
                    }
                }
            }
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
        static void MaxOdd(int[] numbers)
        {
            int maxOdd = int.MinValue;
            int index = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    if (numbers[i] >= maxOdd)
                    {
                        maxOdd = numbers[i];
                        index = i;
                    }
                }
            }
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
        static void MinEven(int[] numbers)
        {
            int minEven = int.MaxValue;
            int index = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (numbers[i] <= minEven)
                    {
                        minEven = numbers[i];
                        index = i;
                    }
                }
            }
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
        static void MinOdd(int[] numbers)
        {
            int minOdd = int.MaxValue;
            int index = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    if (numbers[i] <= minOdd)
                    {
                        minOdd = numbers[i];
                        index = i;
                    }
                }
            }
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
        static void FirstEven(int[] numbers, int count)
        {
            int counter = 0;
            string nums = string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    nums += numbers[i] + " ";
                    counter++;
                }
                if (counter == count)
                {
                    break;
                }
            }
            var result = nums.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", result) + "]");
            }
        }
        static void FirstOdd(int[] numbers, int count)
        {
            int counter = 0;
            string nums = string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    nums += numbers[i] + " ";
                    counter++;
                }
                if (counter == count)
                {
                    break;
                }
            }
            var result = nums.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", result) + "]");
            }
        }
        static void LastEven(int[] numbers, int count)
        {
            int counter = 0;
            string nums = string.Empty;
            for (int i = numbers.Length-1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 0)
                {
                    nums += numbers[i] + " ";
                    counter++;
                }
                if (counter == count)
                {
                    break;
                }
            }
            var result = nums.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", result) + "]");
            }
        }
        static void LastOdd(int[] numbers, int count)
        {
            int counter = 0;
            string nums = string.Empty;
            for (int i = numbers.Length-1; i >= 0; i--)
            {
                if (numbers[i] % 2 != 0)
                {
                    nums += numbers[i] + " ";
                    counter++;
                }
                if (counter == count)
                {
                    break;
                }
            }
            var result = nums.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", result) + "]");
            }
        }
    }
}
