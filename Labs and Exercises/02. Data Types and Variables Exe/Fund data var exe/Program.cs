using System;

namespace Fund_data_var_exe
{
    class Program
    {
        static void Main(string[] args)
        {
            long inputOne = long.Parse(Console.ReadLine());
            long inputTwo = long.Parse(Console.ReadLine());
            long inputThree = long.Parse(Console.ReadLine());
            long inputFour = long.Parse(Console.ReadLine());

            Console.WriteLine($"{((inputOne + inputTwo) / inputThree) * inputFour}");
        }
    }
}
