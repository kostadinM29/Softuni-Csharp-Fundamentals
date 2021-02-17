using System;

namespace _04._password_validator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool invalid = false;
            string text = Console.ReadLine();
            if (!LengthCheck(text))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                invalid = true;
            }
            if (!LetterAndDigitCheck(text))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                invalid = true;
            }
            if (!DigitCheck(text))
            {
                Console.WriteLine("Password must have at least 2 digits");
                invalid = true;
            }
            if (invalid == false)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool LengthCheck(string text)
        {
            if (text.Length < 6 || text.Length > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool LetterAndDigitCheck(string text)
        {
            char[] charArr = text.ToCharArray();
            foreach (char ch in charArr)
            {
                if (!((int)ch >= 65 && (int)ch <= 90 || (int)ch >= 97 && (int)ch <= 122 || (int)ch >= 48 && (int)ch <= 57))
                {
                    return false;
                }
            }
            return true;
        }
        static bool DigitCheck(string text)
        {
            int digitCounter = 0;
            char[] charArr = text.ToCharArray();
            foreach (char ch in charArr)
            {
                if ((int)ch >= 48 && (int)ch <= 57)
                {
                    digitCounter++;
                }
            }
            if (digitCounter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
