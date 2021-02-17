using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._student_academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!(students.ContainsKey(name)))
                {
                    students.Add(name, new List<double>());
                }
                students[name].Add(grade);
            }
            foreach (var student in students)
            {
                double average = student.Value.Sum() / student.Value.Count;
                if (average < 4.50)
                {
                    students.Remove(student.Key);
                }
            }
            Dictionary<string, List<double>> studentsSorted = students.OrderByDescending(x => x.Value.Sum() / x.Value.Count).ToDictionary(x => x.Key, x => x.Value);
            foreach (var student in studentsSorted)
            {
                double average = student.Value.Sum() / student.Value.Count;
                    Console.WriteLine($"{student.Key} -> {average:f2}");
            }
        }
    }
}
