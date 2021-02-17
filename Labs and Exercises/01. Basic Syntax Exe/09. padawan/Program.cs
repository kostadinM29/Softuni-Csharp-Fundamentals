using System;

namespace _09._padawan
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double lsPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double freeBelts = Math.Floor(students / 6);
            double extraLS = Math.Ceiling(students * 0.10);
            double finalSum = lsPrice * (students + extraLS) + (robePrice * students) + beltPrice * (students - freeBelts);
            
            if (finalSum <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {finalSum:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {finalSum - money:F2}lv more.");
            }

        }
    }
}
