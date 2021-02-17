using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();
            while (true)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                if (input[0] == "end")
                {
                    break;
                }
                Student student = new Student();
                student.firstName = input[0];
                student.lastName = input[1];
                student.age = int.Parse(input[2]);
                student.town = input[3];

                studentsList.Add(student);
            }
            string filterTown = Console.ReadLine();
            foreach (Student student in studentsList)
            {
                if (student.town == filterTown)
                {
                    Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
                }
            }
        }
    }
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string town { get; set; }
    }
}
