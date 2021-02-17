using System;

namespace _10._rage_expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            double games = double.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headsetDed = 0;
            double mouseDed = 0;
            double keyboardDed = 0;
            double displayDed = 0;
            double displayCounter = 0;
            for (int i = 1; i <= games; i++)
            {
                if (i % 2 == 0)
                {
                    headsetDed++;
                }
                if (i % 3 == 0)
                {
                    mouseDed++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardDed++;
                    displayCounter++;
                }
                if (displayCounter % 2 == 0 && displayCounter != 0)
                {
                    displayDed++;
                    displayCounter = 0;
                }
            }
            Console.WriteLine($"Rage expenses: {headsetPrice * headsetDed + mousePrice * mouseDed + keyboardPrice * keyboardDed + displayPrice * displayDed:F2} lv.");
        }
    }
}
