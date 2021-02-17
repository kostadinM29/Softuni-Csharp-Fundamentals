using System;

namespace _03._rounding_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split();
            double[] arr = new double[values.Length];


            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = double.Parse(values[i]);
                if (arr[i] == 0)
                {
                    arr[i] = 0;
                }
                Console.WriteLine($"{arr[i]} => {(int)Math.Round(arr[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
