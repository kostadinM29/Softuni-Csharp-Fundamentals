using System;
using System.Text;

namespace _05._multiply_big_num
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine().TrimStart('0');
            int numD = int.Parse(Console.ReadLine());
            if (numD == 0)
            {
                Console.WriteLine(0);
                return;
            }
            StringBuilder sb = new StringBuilder();
            int counter = 0;

            for (int i = num.Length - 1; i >= 0; i--)
            {
                int result = int.Parse(num[i].ToString()) * numD + counter;
                counter = 0;
                if (result > 9)
                {
                    counter = result / 10;
                    result = result % 10;
                }
                sb.Append(result);
            }
            if (counter != 0)
            {
                sb.Append(counter);
            }
            StringBuilder final = new StringBuilder();
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                final.Append(sb[i]);
            }
            Console.WriteLine(final);
        }
    }
}
