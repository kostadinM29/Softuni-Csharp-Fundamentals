using System;

namespace _04._centuries_to_min
{
    class Program
    {
        static void Main(string[] args)
        {
            byte input = byte.Parse(Console.ReadLine());
            short years = (short)(input * 100);
            int days = (int)(years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;
            Console.WriteLine($"{input} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
            
        }
    }
}
