using System;

namespace _03._vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double discount = 1;
            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.80;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16;
                            break;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            price = 15;
                            break;
                        case "Saturday":
                            price = 20;
                            break;
                        case "Sunday":
                            price = 22.50;
                            break;
                    }
                    break;
            }
            if (type == "Business" && numberOfPeople >= 100)
            {
                numberOfPeople -= 10;
            }
            if (type == "Students" && numberOfPeople >= 30)
            {
                discount = 0.85;
            }
            if (type == "Regular" && numberOfPeople >= 10 && numberOfPeople <= 20)
            {
                discount = 0.95;
            }
            Console.WriteLine($"Total price: {(numberOfPeople * price) * discount:F2}");
        }
    }
}
