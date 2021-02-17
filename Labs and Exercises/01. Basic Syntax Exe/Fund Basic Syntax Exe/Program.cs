using System;

namespace Fund_Basic_Syntax_Exe
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string output = "";
            if (age >= 0 && age <= 2)
            {
                output = "baby";
            }
            if(age >= 3 && age <= 13)
            {
                output = "child";
            }
            if (age >= 14 && age <= 19)
            {
                output = "teenager";
            }
            if (age >= 20 && age <= 65)
            {
                output = "adult";
            }
            if (age >= 66)
            {
                output = "elder";
            }
            Console.WriteLine(output);
        }
    }
}
