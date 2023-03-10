namespace BirthdayCelebrations;

public class Citizen : LivingCreatures, IInhabitant
{
    public Citizen(string name, int age, string id, string birthday) : base(name, birthday)
    {
        Age = age;
        Id = id;
    }

    public int Age { get; private set; }

    public string Id { get; private set; }
}
