namespace _05._Filter_By_Age
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            ReadPeople(people);
            string filterType = Console.ReadLine();
            int filterValue = int.Parse(Console.ReadLine());
            string printType = Console.ReadLine();
        }

        private static void ReadPeople(List<Person> people)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[0]);
                people.Add(new Person() { Name = name, Age = age });
            }
        }

        Func<Person, int, bool> CreateFilter(string filterType)
        {
            if (filterType == "younger")
            {
                return (p, value) => p.Age < value;
            }
            else
            {
                return (p, value) => p.Age >= value;
            }
        }
    }

    public class Person
    {
        public string Name;
        public int Age;
    }
}
