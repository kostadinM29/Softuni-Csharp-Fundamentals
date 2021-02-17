using System;
using System.Linq;

namespace _10._top_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TopNumberGenerator(n);
        }
        static void TopNumberGenerator(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                bool by8 = false;
                bool oddNum = false;

                int[] array = i.ToString().Select(t => int.Parse(t.ToString())).ToArray();
                int sum = 0;
                foreach (var num in array)
                {
                    sum += num;
                    if (num % 2 == 0)
                    {
                    }
                    else
                    {
                        oddNum = true;
                    }
                }
                if (sum % 8 == 0)
                {
                    by8 = true;
                }
                if (by8 && oddNum)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
