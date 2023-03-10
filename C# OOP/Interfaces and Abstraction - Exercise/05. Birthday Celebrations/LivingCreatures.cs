namespace BirthdayCelebrations;

public abstract class LivingCreatures : IBornable
{
    protected LivingCreatures(string name, string birthday)
    {
        Name = name;
        Birthday = birthday;
    }
    public string Name { get; private set; }
    public string Birthday { get; private set; }

    public override string ToString()
    {
        return Birthday;
    }
}
