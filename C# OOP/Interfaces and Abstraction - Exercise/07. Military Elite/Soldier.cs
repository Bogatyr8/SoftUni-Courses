namespace MilitaryElite;

public abstract class Soldier
{
    public Soldier(string iD, string firstName, string lastName)
    {
        ID = iD;
        FirstName = firstName;
        LastName = lastName;
    }

    public string ID { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
}
