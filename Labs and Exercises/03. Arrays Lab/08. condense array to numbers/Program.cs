using System;
using System.Globalization;
using System.Linq;

namespace _08._condense_array_to_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int[] nums = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                nums[i] = int.Parse(numbers[i]);
            }
            while (nums.Length != 1)
            {
                int[] newNums = new int[nums.Length - 1];
                for (int i = 0; i < newNums.Length; i++)
                {
                    newNums[i] = nums[i] + nums[i + 1];
                }
                nums = newNums;
            }
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
