using System;
using System.Globalization;

namespace _01._day_of_week
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateInput = Console.ReadLine();


            DateTime date = DateTime.ParseExact(dateInput, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
