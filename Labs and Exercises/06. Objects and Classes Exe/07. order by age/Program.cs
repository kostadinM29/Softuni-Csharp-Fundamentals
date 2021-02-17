using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._order_by_age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                if (command[0] == "End")
                {
                    break;
                }
                Person newPerson = new Person();
                newPerson.Name = command[0];
                newPerson.ID = command[1];
                newPerson.Age = int.Parse(command[2]);

                list.Add(newPerson);
            }
            List<Person> sortedByAge = list.OrderBy(x => x.Age).ToList();
            foreach (Person person in sortedByAge)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

    }
}
