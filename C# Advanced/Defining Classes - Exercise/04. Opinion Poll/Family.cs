using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses;
public class Family
{
    private List<Person> people;
    public Family()
    {
        this.people = new();
    }

    public void AddMember(Person person)
    {
        if (person.Age <= 30)
        {
            return;
        }
        this.people.Add(person);
    }
    public void PrintMembers()
    {
        foreach (var member in people.OrderBy(p => p.Name).ToList())
        {
            Console.WriteLine($"{member.Name} - {member.Age}");
        }
    }
}
