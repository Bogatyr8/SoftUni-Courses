namespace FoodShortage;

public class Citizen : Person, IInhabitant, IBuyer
{
    public Citizen(string name, int age, string id, string birthday) : base(name, age)
    {
        Id = id;
        Birthday = birthday;
    }

    public string Id { get; private set; }
    public string Birthday { get; private set; }


    public override void BuyFood()
    {
        Food += 10;
    }
}
