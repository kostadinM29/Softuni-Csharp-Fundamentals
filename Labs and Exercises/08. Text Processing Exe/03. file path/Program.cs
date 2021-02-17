using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._file_path
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> path = Console.ReadLine().Split('\\').ToList();
            List<string> file = path[path.Count - 1].Split('.').ToList();
            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");
        }
    }
}
