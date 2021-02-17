using System;
using System.Linq;

namespace fund_arrays_exe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                array[i] = num;
                if (i == n-1)
                {
                    Console.WriteLine(array[i]);
                }
                else
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.WriteLine(array.Sum());

        }
    }
}
