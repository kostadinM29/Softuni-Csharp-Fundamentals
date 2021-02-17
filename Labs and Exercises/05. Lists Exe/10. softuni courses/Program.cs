using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._softuni_courses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            while (input != "course start")
            {
                List<string> command = input.Split(':').ToList();
                switch (command[0])
                {
                    case "Add":
                        if (!courses.Contains(command[1]))
                        {
                            courses.Add(command[1]);
                        }
                        break;
                    case "Insert":
                        if (!courses.Contains(command[1]))
                        {
                            int index = int.Parse(command[2]);
                            courses.Insert(index, command[1]);
                        }
                        break;
                    case "Remove":
                        if (courses.Contains(command[1]))
                        {
                            for (int i = 0; i < courses.Count; i++)
                            {
                                if (courses[i] == string.Concat(command[1], "-Exercise"))
                                {
                                    courses.RemoveAt(i);
                                }
                                if (courses[i] == command[1])
                                {
                                    courses.RemoveAt(i);
                                }
                            }
                        }
                        break;
                    case "Swap":
                        if (courses.Contains(command[1]) && courses.Contains(command[2]))
                        {
                            for (int i = 0; i < courses.Count; i++)
                            {
                                if (courses[i] == command[1])
                                {
                                    courses.RemoveAt(i);
                                    courses.Insert(i, command[2]);
                                    continue;
                                }
                                if (courses[i] == command[2])
                                {
                                    courses.RemoveAt(i);
                                    courses.Insert(i, command[1]);
                                    continue;
                                }
                                if (courses[i] == string.Concat(command[1], "-Exercise"))
                                {
                                    string exercise = string.Concat(command[1], "-Exercise");
                                    int idx = courses.IndexOf(command[1]);
                                    courses.RemoveAt(i);
                                    courses.Insert(idx + 1, exercise);
                                }
                                if (courses[i] == string.Concat(command[2], "-Exercise"))
                                {
                                    string exercise = string.Concat(command[2], "-Exercise");
                                    int idx = courses.IndexOf(command[2]);
                                    courses.RemoveAt(i);
                                    courses.Insert(idx + 1, exercise);
                                }
                            }
                        }
                        break;
                    case "Exercise":
                        if (courses.Contains(command[1]))
                        {
                            for (int i = 0; i < courses.Count; i++)
                            {
                                if (courses[i] == command[1] && !courses.Contains(string.Concat(command[1], "-Exercise")))
                                {
                                    
                                    courses.Insert(i + 1, string.Concat(command[1], "-Exercise"));
                                }
                            }
                        }
                        if(!courses.Contains(command[1]))
                        {
                            courses.Insert(courses.Count, command[1]);
                            courses.Insert(courses.Count, string.Concat(command[1], "-Exercise"));
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{courses[i]}");
            }
        }
    }
}
