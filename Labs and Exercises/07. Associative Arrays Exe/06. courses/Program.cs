using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (true)
            {
                List<string> input = Console.ReadLine().Split(" : ").ToList();
                if (input[0] == "end")
                {
                    break;
                }
                string course = input[0];
                string student = input[1];
                if (!(courses.ContainsKey(course)))
                {
                    courses.Add(course, new List<string>());
                }
                courses[course].Add(student);
            }
            foreach (var item in courses.OrderByDescending(x => x.Value.Count))
            {
                List<string> sortedList = item.Value.OrderBy(x => x).ToList();
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"-- {sortedList[i]}");
                }
            }
        }
    }
}
