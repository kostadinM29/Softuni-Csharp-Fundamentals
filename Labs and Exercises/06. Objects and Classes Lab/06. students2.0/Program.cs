using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._students2._0
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
                if (IsStudentExisting(studentsList, input[0], input[1]))
                {
                    Student student = GetStudent(studentsList, input[0], input[1]);
                    student.firstName = input[0];
                    student.lastName = input[1];
                    student.age = int.Parse(input[2]);
                    student.town = input[3];
                }
                else
                {
                    Student student = new Student();

                    student.firstName = input[0];
                    student.lastName = input[1];
                    student.age = int.Parse(input[2]);
                    student.town = input[3];

                    studentsList.Add(student);
                }
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
        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.firstName == firstName && student.lastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;
            foreach (Student student in students)
            {
                if (student.firstName == firstName && student.lastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
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
