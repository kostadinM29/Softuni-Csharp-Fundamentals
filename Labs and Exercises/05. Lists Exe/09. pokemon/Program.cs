using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
        }
    }
}
