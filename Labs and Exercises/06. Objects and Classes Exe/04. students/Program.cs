using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                List<string> studentInputs = Console.ReadLine().Split().ToList();

                Student student = new Student();
                student.FirstName = studentInputs[0];
                student.LastName = studentInputs[1];
                student.Grade = double.Parse(studentInputs[2]);

                students.Add(student);
            }
            List<Student> sortedStudents = students.OrderByDescending(b => b.Grade).ToList();
            foreach (Student student in sortedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

    }
}
