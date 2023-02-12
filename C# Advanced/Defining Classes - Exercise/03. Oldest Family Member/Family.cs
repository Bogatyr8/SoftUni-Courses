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
        this.people.Add(person);
    }
    public Person GetOldestMember()
    {
        return this.people.MaxBy(a => a.Age);
    }
}
