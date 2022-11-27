using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
//You will receive an unknown number of lines. On each line you will receive an array with 3 elements:
//•	The first element is a string -the name of the person
//•	The second element a string -the ID of the person
//•	The third element is an integer - the age of the person
//If you get a person whose ID you have already received before, update the name and age for that ID with that of the new person.
//When you receive the command "End", print all of the people, ordered by age.
            List<Person> people = new List<Person>();
            string inputString;

            while ((inputString = Console.ReadLine()) != "End")
            {
                string[] input = inputString
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                Person person = new Person(name, id, age);

                if (people.Count == 0)
                {
                    people.Add(person);
                }
                else
                {
                    foreach (var item in people)
                    {
                        if (item.Id == id)
                        {
                            item.Name = name;
                            item.Age = age;
                            break;
                        }
                        else
                        {
                            people.Add(person);
                            break;
                        }
                    }

                }
                
            }

            people = people
                .OrderBy(p => p.Age)
                .ToList();

            foreach (var item in people)
            {
                Console.WriteLine($"{item.Name} with ID: {item.Id} is {item.Age} years old.");
            }
        }
    }

    public class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
        public string Name { get; set; }
        public string Id { get; private set; }
        public int Age { get; set; }
    }
}
