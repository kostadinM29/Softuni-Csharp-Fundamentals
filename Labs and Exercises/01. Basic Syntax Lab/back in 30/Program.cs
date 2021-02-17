using System;

namespace back_in_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            int addedminute = minute + 30;

            if (addedminute > 59)
            {
                addedminute -= 60;
                hour += 1;
                if (hour > 23)
                {
                    hour = 0;
                }
            }
            Console.WriteLine($"{hour}:{addedminute:D2}");

        }
    }
}
