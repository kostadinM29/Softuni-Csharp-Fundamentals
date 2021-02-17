using System;

namespace _10._pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int pokes = 0;
            int originalN = n;
            while (n >= m)
            {
                if (2 * n == originalN && y > 0)
                {
                    n /= y;
                    if (n < m)
                    {
                        break;
                    }
                }
                n -= m;
                pokes++;
            }
            Console.WriteLine(n);
            Console.WriteLine(pokes);
        }
    }
}
