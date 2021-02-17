using System;

namespace _07._vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalMoney = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Start")
                {
                    break;
                }
                double money = Double.Parse(input);
                if (money == 2.0 || money == 1.0 || money == 0.5 || money == 0.2 || money == 0.1)
                {
                    totalMoney += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }

            }
            while (true)
            {
                string purchase = Console.ReadLine();
                if (purchase == "End")
                {
                    Console.WriteLine($"Change: {totalMoney:F2}");
                    break;
                }
                else if (purchase == "Nuts")
                {
                    if (totalMoney >= 2.0)
                    {
                        Console.WriteLine($"Purchased nuts");
                        totalMoney -= 2.0;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (purchase == "Water")
                {
                    if (totalMoney >= 0.7)
                    {
                        Console.WriteLine($"Purchased water");
                        totalMoney -= 0.7;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (purchase == "Crisps")
                {
                    if (totalMoney >= 1.5)
                    {
                        Console.WriteLine($"Purchased crisps");
                        totalMoney -= 1.5;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (purchase == "Soda")
                {
                    if (totalMoney >= 0.8)
                    {
                        Console.WriteLine($"Purchased soda");
                        totalMoney -= 0.8;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (purchase == "Coke")
                {
                    if (totalMoney >= 1.0)
                    {
                        Console.WriteLine($"Purchased coke");
                        totalMoney -= 1.0;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (purchase != "End" || purchase != "Coke" || purchase != "Soda" || purchase != "Crisps" || purchase != "Water" || purchase != "Nuts")
                {
                    Console.WriteLine("Invalid product");
                }
            }
        }
    }
}
