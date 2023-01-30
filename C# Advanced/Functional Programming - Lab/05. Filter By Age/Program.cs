namespace _05._Filter_By_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            ReadPeople(people);
            string filterType = Console.ReadLine();
            int filterValue = int.Parse(Console.ReadLine());
            string printType = Console.ReadLine();
            Func<Person, int, bool> filter = CreateFilter(filterType);
            people = people.Where(p => filter(p, filterValue)).ToList();
            Action<Person> printer = GetPrinter(printType);
            people.ForEach(printer);
        }

        private static void ReadPeople(List<Person> people)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                people.Add(new Person() { Name = name, Age = age });
            }
        }

        private static Action<Person> GetPrinter(string printType)
        {
            if (printType == "name")
            {
                return s => Console.WriteLine(s.Name);
            }
            else if (printType == "age")
            {
                return s => Console.WriteLine(s.Age);
            }
            else if (printType == "name age")
            {
                return s => Console.WriteLine($"{s.Name} - {s.Age}");
            }
            else
            {
                return null;
            }
        }

        private static Func<Person, int, bool> CreateFilter(string filterType)
        {
            if (filterType == "younger")
            {
                return (Person p, int value) => p.Age < value;
            }
            else
            {
                return (Person p, int value) => p.Age >= value;
            }
        }
    }

    public class Person
    {
        public string Name;
        public int Age;
    }
}
